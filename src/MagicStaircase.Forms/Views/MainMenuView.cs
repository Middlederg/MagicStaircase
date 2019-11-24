using System;
using System.Windows.Forms;
using MagicStaircase.Core.Model;
using System.Diagnostics;
using MagicStaircase.Core;

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
                    Version.Text += " Up to date";
                else
                    Version.Text += $"Version {await updateChecker.LastRelease()} avaliable";
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
