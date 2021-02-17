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

        public Card Card { get; private set; }
        public bool HasVisibleCard => Card != null;

        public DragEventHandler CardDrop { get; set; }


        public void Clean()
        {
            Card = null;
            Text = "";
            BackColor = SystemColors.Control;
            MouseDown -= CardMouseDown;
        }

        public void SetValue(int value)
        {
            Text = value.ToString();
            BackColor = Color.White;
            Card = new Card(value);
        }

        public Carta()
        {
            InitializeComponent();
            Font = new Font("Courier new", FontSize, FontStyle.Regular);
            BorderStyle = BorderStyle.FixedSingle;
            MouseDown += CardMouseDown;
            DragDrop += CardDrop;
        }

        public void SetCardDropEvent(DragEventHandler cardDrop)
        {
            DragDrop += cardDrop;
            AllowDrop = true;
        }

        private void CardMouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this, DragDropEffects.Copy | DragDropEffects.Move);
        }
    }
}
