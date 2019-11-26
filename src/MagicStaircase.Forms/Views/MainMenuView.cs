using System;
using System.Windows.Forms;
using System.Diagnostics;
using MagicStaircase.Core;
using System.Runtime.InteropServices;

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
            using (MainView f = new MainView())
            {
                Visible = false;
                f.ShowDialog();
                Visible = true;
            }
        }

        private void BtnBestScores_Click(object sender, EventArgs e)
        {
            using (BestScoresView f = new BestScoresView())
            {
                Visible = false;
                f.ShowDialog();
                Visible = true;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e) => Application.Exit();
        private void Repo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(Configuration.RepoLink);
        
        private async void OnLoad(object sender, EventArgs e)
        {
            try
            {
                var updateChecker = new UpdateChecker();
                if (await updateChecker.IsUpToDate())
                    Version.Text += " Program is up to date";
                else
                    Version.Text += $"Version {await updateChecker.LastRelease()} avaliable";
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
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

        }

        #endregion
    }
}
