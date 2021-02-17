﻿using FontAwesome.Sharp;
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
        private int totalPlacedCardsInTurn;
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
            totalPlacedCardsInTurn = 0;
            CartaUp1.Numero = CartaUp2.Numero = 1;
            CartaDown1.Numero = CartaDown2.Numero = 99;
            CartaUp1.Place(Direction.Up, CardDrop);
            CartaUp2.Place(Direction.Up, CardDrop);
            CartaDown1.Place(Direction.Down, CardDrop);
            CartaDown2.Place(Direction.Down, CardDrop);

            game = new Game();
            FlpMano.Controls.Clear();
            for (int i = 0; i < Game.PlayerCardCount; i++)
            {
                FlpMano.Controls.Add(new Carta(game.TakeCard()));
            }
            PrintScore();
        }

        private void PrintScore() => LblPuntuacion.Text = $"Score: {game.Points(CardsInHand().Count())}/100";

        private async void CardDrop(object sender, DragEventArgs e)
        {
            var origen = e.Data.GetData(typeof(Carta)) as Carta;
            var destino = sender as Carta;
            if (origen.Fits(destino))
            {
                var panelDestino = destino.Parent as Panel;
                panelDestino.Controls.Remove(destino);

                int indxCarta = int.Parse(panelDestino.Tag.ToString());
                game.AddToPile(origen.Numero, indxCarta);
                string ayuda = string.Join("\n", game.Piles.ElementAt(indxCarta));
                
                var nuevaCarta = new Carta(origen.Numero);
                ToolTipAyuda.SetToolTip(nuevaCarta, ayuda);
                panelDestino.Controls.Add(nuevaCarta);
                nuevaCarta.Place(destino.Direction, CardDrop);
                origen.Placed();

                totalPlacedCardsInTurn++;
                BtnNext.Enabled = totalPlacedCardsInTurn >= Game.MinCardPerTurn;
                PrintScore();
                PutInGrayNonPlayableCards();

                if ((CardsInHand().Count() > Game.PlayerCardCount - Game.MinCardPerTurn) && !IsPlayableCard())
                {
                    await EndGame();
                }
            }
        }

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            if (totalPlacedCardsInTurn >= 2)
            {
                foreach (var carta in CardsPlayed())
                {
                    if (game.HasCards)
                        carta.Numero = game.TakeCard();
                }
                totalPlacedCardsInTurn = 0;
                PutInGrayNonPlayableCards();

                if (!IsPlayableCard())
                {
                    await EndGame();
                }
            }
        }

        private Carta GetCarta(Panel p) => p.Controls[0] as Carta;
        private IEnumerable<Carta> CardsPlayed() => FlpMano.Controls.OfType<Carta>().Where(x => x.Numero == 0);
        private IEnumerable<Carta> CardsInHand() => FlpMano.Controls.OfType<Carta>().Where(x => x.Numero != 0);
        private bool IsPlayableCard()
        {
            foreach (Carta c in CardsInHand())
            {
                if (c.Fits(GetCarta(pUp1)) || c.Fits(GetCarta(pUp2)) || c.Fits(GetCarta(pDown1)) || c.Fits(GetCarta(pDown2)))
                    return true;
            }
            return false;
        }

        private void PutInGrayNonPlayableCards()
        {
            foreach (Carta c in CardsInHand())
            {
                if (!c.Fits(GetCarta(pUp1)) && !c.Fits(GetCarta(pUp2)) && !c.Fits(GetCarta(pDown1)) && !c.Fits(GetCarta(pDown2)))
                {
                    c.BackColor = SystemColors.Control;
                    ToolTipAyuda.SetToolTip(c, "This card can not be placed :(");
                }
                else
                {
                    c.BackColor = Color.White;
                    ToolTipAyuda.SetToolTip(c, "");
                }
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
            using (var gameEndView = new GameEndView(game.Points(CardsInHand().Count()), time))
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
