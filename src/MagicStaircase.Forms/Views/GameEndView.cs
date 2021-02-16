using FontAwesome.Sharp;
using MagicStaircase.Core;
using MagicStaircase.Core.Repositories;
using MagicStaircase.Forms.CustomControls;
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

        private async void OnLoad(object sender, EventArgs e)
        {
            Flp.Controls.Clear();
            foreach (var achievement in await AchievementsAvaliable())
            {
                if (achievement.TryToUnlockAchievement(Score))
                {
                    AchievementsTitleLabel.Text = "Acievements unlocked:";
                    Flp.Controls.Add(new AchievementControl()
                    {
                        BackColor = Color.Linen,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(15, 15, 0, 0),
                        Achievement = achievement,
                        UnlockerScores = new List<Score>() { Score }
                    });
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
      
        private async Task<IEnumerable<Achievement>> AchievementsAvaliable()
        {
            var scores = await new LocalFileScoreRepository().GetScores();
            var achievements = new List<Achievement>();
            foreach (var achievement in AchievementFactory.Achievements)
            {
                if (!scores.Any(x => achievement.TryToUnlockAchievement(x)))
                    achievements.Add(achievement);
            }
            return achievements;
        }
    }
}
