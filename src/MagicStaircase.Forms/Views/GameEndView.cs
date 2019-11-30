using FontAwesome.Sharp;
using MagicStaircase.Core;
using MagicStaircase.Core.Repositories;
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
        private readonly List<Achievement> achievementsUnlocked = new List<Achievement>();

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

        private async void OnLoad(object sender, EventArgs e)
        {
            foreach (var achievement in await AchievementsAvaliable())
            {
                if (achievement.AchievementUnlocked(Score))
                {
                    achievementsUnlocked.Add(achievement);
                }
            }
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

        private async void AchievementsButton_Click(object sender, EventArgs e)
        {
            using (AchievementsView f = new AchievementsView()
            {
                Scores = new List<Score>() { Score },
                Achievements = await AchievementsAvaliable()
            })
            {
                Visible = false;
                f.ShowDialog();
                Visible = true;
            }
        }
      
        private async Task<IEnumerable<Achievement>> AchievementsAvaliable()
        {
            var scores = await new ScoreRepository().GetScores();
            var achievements = new List<Achievement>();
            foreach (var achievement in AchievementFactory.Achievements)
            {
                if (!scores.Any(x => achievement.AchievementUnlocked(x)))
                    achievements.Add(achievement);
            }
            return achievements;
        }
    }
}
