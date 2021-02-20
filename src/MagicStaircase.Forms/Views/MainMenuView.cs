using System;
using System.Windows.Forms;
using System.Diagnostics;
using MagicStaircase.Core;
using System.Runtime.InteropServices;
using MagicStaircase.Core.Repositories;
using System.Threading.Tasks;

namespace MagicStaircase.Forms
{
    public partial class MainMenuView : Form
    {
        public MainMenuView()
        {
            InitializeComponent();
            Version.Text = $"Current version: {Configuration.CurrentVersion()}";
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            bool beginAgain = false;
            do
            {
                using (MainView f = new MainView())
                {
                    Visible = false;
                    f.ShowDialog();
                    beginAgain = f.BeginAgain;
                }
            }
            while (beginAgain);
            Visible = true;
        }

        private async void BtnBestScores_Click(object sender, EventArgs e)
        {
            AchievementsButton.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            AchievementsButton.Text = "LOADING...";
            var scores = await new LocalFileScoreRepository().GetScores();

            using (AchievementsView f = new AchievementsView()
            {
                Scores = scores,
                Achievements = AchievementFactory.Achievements
            })
            {
                Visible = false;
                f.ShowDialog();
                Visible = true;
            }
            AchievementsButton.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            AchievementsButton.Text = "ACHIEVEMENTS";
        }

        private void BtnExit_Click(object sender, EventArgs e) => Application.Exit();
        private void Repo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("explorer.exe", Configuration.RepoLink);
        
        private async void OnLoad(object sender, EventArgs e)
        {
            try
            {
                var updateChecker = new UpdateChecker();
                if (await updateChecker.IsUpToDate())
                {
                    TlpPrincipal.Controls.Add(new Label()
                    {
                        Text = "Program is up to date",
                        Dock = DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    }, 1, 5);
                }
                else
                {
                    var linkLabel = new LinkLabel()
                    {
                        Text = $"Version {await updateChecker.LastRelease()} avaliable",
                        Dock = DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    };
                    linkLabel.Click += OnNewVersionLink;
                    TlpPrincipal.Controls.Add(linkLabel, 1, 5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnNewVersionLink(object sender, EventArgs e)
        {
            Process.Start(Configuration.LatestRelease);
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
    }
}
