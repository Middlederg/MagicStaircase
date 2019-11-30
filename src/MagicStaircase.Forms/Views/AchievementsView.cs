using FontAwesome.Sharp;
using MagicStaircase.Core;
using MagicStaircase.Core.Repositories;
using MagicStaircase.Forms.CustomControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicStaircase.Forms
{
    public partial class AchievementsView : Form
    {
        public IEnumerable<Score> Scores { get; set; }

        private IEnumerable<Achievement> achievements;
        public IEnumerable<Achievement> Achievements 
        {
            get => achievements;
            set
            {
                achievements = value;
                Flp.Controls.Clear();
                foreach (var achievement in value)
                {
                    Flp.Controls.Add(new AchievementControl()
                    {
                        BackColor = Color.Linen,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(15, 15, 0, 0),
                        Achievement = achievement,
                        UnlockerScores = Scores.Where(x => achievement.AchievementUnlocked(x))
                    });
                }
            }
        }

        public AchievementsView()
        {
            InitializeComponent();
            Icon = System.Drawing.Icon.FromHandle(IconChar.Trophy.ToBitmap(98, Color.Black).GetHicon());
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

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
