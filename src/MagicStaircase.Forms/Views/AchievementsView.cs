using FontAwesome.Sharp;
using MagicStaircase.Core;
using MagicStaircase.Core.Repositories;
using MagicStaircase.Forms.CustomControls;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicStaircase.Forms
{
    public partial class BestScoresView : Form
    {
        public BestScoresView()
        {
            InitializeComponent();
            Icon = System.Drawing.Icon.FromHandle(IconChar.Trophy.ToBitmap(98, Color.Black).GetHicon());
        }

        private async Task LoadAchievements()
        {
            var scores = await new ScoreRepository().GetScores();

            foreach (var achievement in AchievementFactory.Achievements)
            {
                Flp.Controls.Add(new AchievementControl()
                {
                    BackColor = Color.Linen,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(15, 15, 0, 0),
                    Achievement = achievement,
                    UnlockerScores = scores.Where(x => achievement.AchievementUnlocked(x))
                });

            }
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            await LoadAchievements();
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}
