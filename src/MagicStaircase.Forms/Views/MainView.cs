using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicStaircase.Forms.CustomControls;
using MagicStaircase.Core;
using MagicStaircase.Core.Repositories;

namespace MagicStaircase.Forms
{
    public partial class MainView : Form
    {
        private Game game;
        private Time time;

        public bool BeginAgain { get; private set; }

        public MainView()
        {
            InitializeComponent();
            InitializeGame();          
        }

        private void InitializeGame()
        {
            time = new Time();
            BtnNext.Enabled = false;
            pila1.Initialize(Direction.Up, 0, OnCardPlaced);
            pila2.Initialize(Direction.Up, 1, OnCardPlaced);
            pila3.Initialize(Direction.Down, 2, OnCardPlaced);
            pila4.Initialize(Direction.Down, 3, OnCardPlaced);
            //CartaUp1.Numero = CartaUp2.Numero = 1;
            //CartaDown1.Numero = CartaDown2.Numero = 99;
            //CartaUp1.Place(Direction.Up, CardDrop);
            //CartaUp2.Place(Direction.Up, CardDrop);
            //CartaDown1.Place(Direction.Down, CardDrop);
            //CartaDown2.Place(Direction.Down, CardDrop);

            game = new Game();
            FlpMano.Controls.Clear();
            foreach (var card in game.PlayerHand.Cards)
            {
                var cardControl = new Carta();
                cardControl.SetValue(card.Number);
                FlpMano.Controls.Add(cardControl);
            }
            PrintScore();
        }

        private void PrintScore() => LblPuntuacion.Text = $"Score: {game.Points()}/100";

        private async Task OnCardPlaced(Card card, int pileIndex)
        {
            game.Play(card.Number, pileIndex);
            BtnNext.Enabled = game.CanPass;
            PrintScore();
            PutInGrayNonPlayableCards();

            if (game.IsGameEnd())
            {
                await EndGame();
            }
        }

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            if (game.CanPass)
            {
                RefillHand();
                PutInGrayNonPlayableCards();
                BtnNext.Enabled = false;

                if (!game.IsPlayableCard())
                {
                    await EndGame();
                }
            }
        }

        private IEnumerable<Carta> CardsInHand() => FlpMano.Controls.OfType<Carta>().Where(x => x.HasCard);
        private IEnumerable<Carta> PlayedCards()
        {
            return FlpMano.Controls.OfType<Carta>()
                .Where(x => !x.HasCard);
        }

        private void PutInGrayNonPlayableCards()
        {
            foreach (Carta card in CardsInHand())
            {
                if (game.CardCanBePlaced(card.Card))
                {
                    card.Reenable();
                }
                else
                {
                    card.Disable();
                }
            }
        }

        private void RefillHand()
        {
            var newNumbers = game.RefillHand().ToList();

            foreach (var (card, index) in PlayedCards().Select((card, index) => (card, index)))
            {
                var number = newNumbers.ElementAt(index);
                card.SetValue(number);
            }
        }

        private void BtnMaxClick(object sender, EventArgs e) => BarraSuperiorDobleClick(null, null);
        private void BtnMinClick(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void BtnCloseClick(object sender, EventArgs e) => Close();
        private void BarraSuperiorDobleClick(object sender, EventArgs e)
           => WindowState = WindowState.Equals(FormWindowState.Maximized) ?
            FormWindowState.Normal :
            FormWindowState.Maximized;

        #region MoverFormulario

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void MoveFormMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void BtnReset_Click(object sender, EventArgs e)
        {
            BeginAgain = true;
            Close();
        }

        private void BtnExit_Click(object sender, EventArgs e) => Close();

        private async Task EndGame()
        {
            StopTimer();
            using (var gameEndView = new GameEndView(game.Points(), time))
            {
                if (gameEndView.ShowDialog() == DialogResult.OK)
                {
                    await new LocalFileScoreRepository().AddScore(gameEndView.Score);
                }
            }
            DisableButtons();
        }

        private void StopTimer() => Timer.Enabled = false;
        private void DisableButtons()
        {
            BtnNext.Enabled = false;
            BtnReset.Enabled = false;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            time.NextSecond();
            LblTiempo.Text = time.ToString();
        }
    }
}
