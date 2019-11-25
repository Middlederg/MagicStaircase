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

namespace MagicStaircase.Forms
{
    public partial class GameEndView : Form
    {
        private readonly int points;
        private readonly Time time;

        public Score Score => new Score(new Player(NameTextbox.Text.Trim()), points, time);

        public GameEndView(int points, Time time)
        {
            InitializeComponent();
            this.points = points;
            this.time = time;

            Icon = System.Drawing.Icon.FromHandle(IconChar.HourglassEnd.ToBitmap(98, Color.Black).GetHicon());
            LblPuntuacion.Text = $"Score: {points}";
            LblValoracion.Text = Score.Message;
            LblTiempo.Text = $"Time: {time.ToString()}";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextbox.Text))
            {
                MessageBox.Show(this, "Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public void DisableCancel() => BtnCancel.Enabled = false;
    }
}
