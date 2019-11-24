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
using MagicStaircase.Core.Model;
using MagicStaircase.Forms.CustomControls;
using MagicStaircase.Core;

namespace MagicStaircase.Forms
{
    public partial class MainView : Form
    {
        private Game game;
        private int numColocadas;
        private int segundos;

        public MainView()
        {
            InitializeComponent();
            Reiniciar();          
        }

        private void Reiniciar()
        {
            segundos = 0;
            BtnNext.Enabled = false;
            numColocadas = 0;
            CartaUp1.Numero = CartaUp2.Numero = 1;
            CartaDown1.Numero = CartaDown2.Numero = 99;
            CartaUp1.Colocar(Direction.Up, CardDrop);
            CartaUp2.Colocar(Direction.Up, CardDrop);
            CartaDown1.Colocar(Direction.Down, CardDrop);
            CartaDown2.Colocar(Direction.Down, CardDrop);

            game = new Game();
            FlpMano.Controls.Clear();
            for (int i = 0; i < Game.PlayerCardCount; i++)
            {
                FlpMano.Controls.Add(new Carta(game.TakeCard()));
            }
        }

        private void CardDrop(object sender, DragEventArgs e)
        {
            var origen = e.Data.GetData(typeof(Carta)) as Carta;
            var destino = sender as Carta;
            if (origen.Fits(destino))
            {
                var panelDestino = destino.Parent as Panel;
                panelDestino.Controls.Remove(destino);

                int indxCarta = Int32.Parse(panelDestino.Tag.ToString());
                game.AddToPile(origen.Numero, indxCarta);
                string ayuda = string.Join("\n", game.Piles[indxCarta].Select(x => x.ToString()));
                
                var nuevaCarta = new Carta(origen.Numero);
                ToolTipAyuda.SetToolTip(nuevaCarta, ayuda);
                panelDestino.Controls.Add(nuevaCarta);
                nuevaCarta.Colocar(destino.Direccion, CardDrop);
                origen.Colocada();

                numColocadas++;
                BtnNext.Enabled = (numColocadas >= Game.MinCardPerTurn);
                LblPuntuacion.Text = $"Score: {game.Points}";
                ColorearCartas();

                if ((CartasMano().Count() > Game.PlayerCardCount - Game.MinCardPerTurn) && !ExisteCartaColocable())
                    JuegoTerminado();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (numColocadas >= 2)
            {
                foreach (var carta in CartasVacias())
                {
                    if (game.HasCards)
                        carta.Numero = game.TakeCard();
                }
                numColocadas = 0;
                ColorearCartas();

                if (!ExisteCartaColocable())
                    JuegoTerminado();
            }
        }

        private Carta GetCarta(Panel p) => p.Controls[0] as Carta;
        private IEnumerable<Carta> CartasVacias() => FlpMano.Controls.OfType<Carta>().Where(x => x.Numero == 0);
        private IEnumerable<Carta> CartasMano() => FlpMano.Controls.OfType<Carta>().Where(x => x.Numero != 0);
        private bool ExisteCartaColocable()
        {
            foreach (Carta c in CartasMano())
            {
                if (c.Fits(GetCarta(pUp1)) || c.Fits(GetCarta(pUp2)) || c.Fits(GetCarta(pDown1)) || c.Fits(GetCarta(pDown2)))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Pone en gris las cartas que no se pueden colocar
        /// </summary>
        /// <returns></returns>
        private void ColorearCartas()
        {
            foreach (Carta c in CartasMano())
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
        private void BtnCloseClick(object sender, EventArgs e) => Application.Exit();
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
            game.Reset();
            Reiniciar();
        }

        private void BtnExit_Click(object sender, EventArgs e) => Close();

        private void JuegoTerminado()
        {
            //Detenemos el tiempo
            T.Enabled = false;

            //Mostrar pantalla fin de juego
            using (var f = new GameEndView(game.Points, segundos)) { f.ShowDialog(); }

            //Registrar puntuación obtenida
            Data.Negocio.ScoreRepository.AddNuevoRegistro(game.Points, segundos);

            BtnNext.Enabled = false;
            BtnReset.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            LblTiempo.Text = new Time(segundos).ToString();
        }
    }
}
