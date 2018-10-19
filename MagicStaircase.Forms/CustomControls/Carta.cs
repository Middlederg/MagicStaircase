using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicStaircase.Core.Model;

namespace MagicStaircase.Forms.CustomControls
{
    public partial class Carta : Label
    {
        public int FontSize { get; set; } = 40;

        private int numero;
        public int Numero
        {
            get { return numero; }
            set
            {
                numero = value;
                if (numero == 0)
                {
                    Text = "";
                    BackColor = SystemColors.Control;
                }
                else
                {
                    Text = numero.ToString();
                    BackColor = Color.White;
                }
            }
        }


        public Direction Direccion { get; set; }

        public Carta()
        {
            InitializeComponent();
            numero = 1;
        }

        public Carta(int numero)
        {
            InitializeComponent();
            Numero = numero;
            Font = new Font("Courier new", FontSize, FontStyle.Regular);
            BorderStyle = BorderStyle.FixedSingle;
            MouseDown += Carta_MouseDown;
        }

        public void Colocar(Direction direccion, DragEventHandler cardDrop)
        {
            BorderStyle = BorderStyle.None;
            Font = new Font("Courier new", 20, FontStyle.Bold);
            TextAlign = ContentAlignment.TopCenter;
            Image = GetArrowIcon(direccion.Equals(Direction.Up) ? IconChar.ArrowUp : IconChar.ArrowDown);
            Direccion = direccion;
            AllowDrop = true;
            MouseDown -= Carta_MouseDown;
            DragEnter += CardEnter;
            DragDrop += cardDrop;
        }

        public void Colocada() => Numero = 0;

        private void Carta_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void CardEnter(object sender, DragEventArgs e)
        {
            var origen = e.Data.GetData(typeof(Carta)) as Carta;
            var destino = sender as Carta;
            e.Effect = (origen.Fits(destino)) ?
                        DragDropEffects.Copy :
                        DragDropEffects.None;
        }

        protected override void OnPaint(PaintEventArgs pe) => base.OnPaint(pe);

        public bool Greater(Carta obj) => numero > obj.Numero;
        public bool Lower(Carta obj) => numero < obj.Numero;
        public bool DiezMenos(Carta obj) => numero == obj.Numero - 10;
        public bool DiezMas(Carta obj) => numero == obj.Numero + 10;

        public bool Fits(Carta obj)
        {
            if(obj.Direccion.Equals(Direction.Up)) return (Greater(obj) || DiezMenos(obj));
            if(obj.Direccion.Equals(Direction.Down)) return (Lower(obj) || DiezMas(obj));
            return false;
        }

        private Image GetArrowIcon(IconChar icn) => icn.ToBitmap(50, Color.Black);
    }
}
