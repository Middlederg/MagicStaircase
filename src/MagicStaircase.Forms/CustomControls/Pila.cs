using FontAwesome.Sharp;
using MagicStaircase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicStaircase.Forms.CustomControls
{
    public partial class Pila : Label
    {
        public int FontSize { get; set; } = 20;

        private Pile pile;

        public Pila()
        {
            InitializeComponent();
            pile = new Pile(Direction.Up, 1);
        }

        public void Initialize(Direction direction, int index, Func<Card, int, Task> onCardPlaced)
        {
            pile = new Pile(direction, index);
            BackColor = Color.White;
            Font = new Font("Courier new", FontSize, FontStyle.Bold);
            Image = GetArrowIcon(direction == Direction.Up ? IconChar.ArrowUp : IconChar.ArrowDown);
            AllowDrop = true;
            DragEnter += CardEnter;
            DragDrop += CardDrop;
            OnCardPlaced = onCardPlaced;
        }

        public Func<Card, int, Task> OnCardPlaced { get; set; }

        private void CardEnter(object sender, DragEventArgs e)
        {
            var origin = e.Data.GetData(typeof(Carta)) as Carta;
            e.Effect = origin.HasCard && pile.Fits(origin.Card) ?
                        DragDropEffects.Copy :
                        DragDropEffects.None;
        }

        private async void CardDrop(object sender, DragEventArgs e)
        {
            var origin = e.Data.GetData(typeof(Carta)) as Carta;
            //var destino = sender as Carta;
            if (origin.HasCard && pile.Fits(origin.Card))
            {
                pile.Add(origin.Card);
                //HelpTooltip.SetToolTip(this, pile.ToString());
                Text = origin.Card.ToString();
                await OnCardPlaced(origin.Card, pile.Index);
                origin.Clean();
            }
        }

        private Image GetArrowIcon(IconChar icn) => icn.ToBitmap(50, Color.Black);
        
    }
}
