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
using MagicStaircase.Core;

namespace MagicStaircase.Forms.CustomControls
{
    public partial class Carta : Label
    {
        public int FontSize { get; set; } = 40;

        private int number;
        public int Numero
        {
            get { return number; }
            set
            {
                number = value;
                if (number == 0)
                {
                    Text = "";
                    BackColor = SystemColors.Control;
                }
                else
                {
                    Text = number.ToString();
                    BackColor = Color.White;
                }
            }
        }

        public Direction Direction { get; set; }

        public Carta()
        {
            InitializeComponent();
            number = 1;
        }

        public Carta(int numero)
        {
            InitializeComponent();
            Numero = numero;
            Font = new Font("Courier new", FontSize, FontStyle.Regular);
            BorderStyle = BorderStyle.FixedSingle;
            MouseDown += Carta_MouseDown;
        }

        public void Place(Direction direccion, DragEventHandler cardDrop)
        {
            BorderStyle = BorderStyle.None;
            Font = new Font("Courier new", 20, FontStyle.Bold);
            TextAlign = ContentAlignment.TopCenter;
            Image = GetArrowIcon(direccion.Equals(Direction.Up) ? IconChar.ArrowUp : IconChar.ArrowDown);
            Direction = direccion;
            AllowDrop = true;
            MouseDown -= Carta_MouseDown;
            DragEnter += CardEnter;
            DragDrop += cardDrop;
        }

        public void Placed() => Numero = 0;

        private void Carta_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void CardEnter(object sender, DragEventArgs e)
        {
            var origin = e.Data.GetData(typeof(Carta)) as Carta;
            var destiny = sender as Carta;
            e.Effect = (origin.Fits(destiny)) ?
                        DragDropEffects.Copy :
                        DragDropEffects.None;
        }

        protected override void OnPaint(PaintEventArgs pe) => base.OnPaint(pe);

        public bool Greater(Carta obj) => number > obj.Numero;
        public bool Lower(Carta obj) => number < obj.Numero;
        public bool TenLess(Carta obj) => number == obj.Numero - 10;
        public bool TenMore(Carta obj) => number == obj.Numero + 10;

        public bool Fits(Carta obj)
        {
            if(obj.Direction.Equals(Direction.Up)) return (Greater(obj) || TenLess(obj));
            if(obj.Direction.Equals(Direction.Down)) return (Lower(obj) || TenMore(obj));
            return false;
        }

        private Image GetArrowIcon(IconChar icn) => icn.ToBitmap(50, Color.Black);
    }
}
