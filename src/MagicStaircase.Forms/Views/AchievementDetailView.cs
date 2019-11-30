using MagicStaircase.Core;
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

namespace MagicStaircase.Forms
{
    public partial class AchievementDetailView : Form
    {
        public AchievementDetailView(Achievement achievement, IEnumerable<Score> scores)
        {
            InitializeComponent();

            LblTitulo.Text = achievement.ToString();
            DescriptionLabel.Text = achievement.Description();

            LvwScores.Columns.AddRange(new string[] { "Player", "Points", "Date", "Time" }.Select(x => new ColumnHeader() { Text = x }).ToArray());
            foreach (var score in scores)
            {
                ListViewItem item = new ListViewItem(score.Player.ToString());
                item.SubItems.Add(score.Points.ToString());
                item.SubItems.Add(score.Date.ToShortDateString());
                item.SubItems.Add(score.Time.ToString());
                LvwScores.Items.Add(item);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();
        private void BtnMin_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

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
    }
}
