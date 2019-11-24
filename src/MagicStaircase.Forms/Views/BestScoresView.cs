using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagicStaircase.Forms
{
    public partial class BestScoresView : Form
    {
        private bool all = false;
        public BestScoresView()
        {
            InitializeComponent();
            Icon = System.Drawing.Icon.FromHandle(IconChar.PenFancy.ToBitmap(98, Color.Black).GetHicon());
            FillListView();
        }

        private void BtnAchievements_Click(object sender, EventArgs e)
        {
            all = !all;
            FillListView();
        }

        private void FillListView()
        {
            var lista = all ?
                Data.Negocio.ScoreRepository.GetScores() :
                Data.Negocio.ScoreRepository.GetRegistrosJugador();
            BtnAchievements.BackColor = all ? Color.SeaGreen : SystemColors.Control;
            BtnAchievements.ForeColor = all ? Color.White : Color.Black;
            BtnAchievements.IconColor = all ? Color.White : Color.Black;
            int i = 1;
            Lvw.Items.Clear();
            foreach (var registro in lista)
            {
                //int? pos = registro.Sistema ? (int?)null : i++;
                //TODO
                //Lvw.FillWith(i, )
                //Lvw.Items.Add(registro.Item(pos));
            }
        }

        private void BtnResetScores_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(this, "Are you sure you want to reset all the scores?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                Data.Negocio.ScoreRepository.ResetRegistros();
            FillListView();
        }
    }
}
