﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicStaircase.Core;

namespace MagicStaircase.Forms.CustomControls
{
    public partial class AchievementControl : UserControl
    {
        private readonly Color InactiveColor = Color.SlateGray;
        private readonly Color ActiveColor = Color.SeaGreen;

        private Achievement achievement;
        public Achievement Achievement 
        {
            get => achievement;
            set
            {
                achievement = value;
                NameLabel.Text = achievement.ToString();
            }
        }

        private IEnumerable<Score> unlockerScores;
        public IEnumerable<Score> UnlockerScores
        {
            get => unlockerScores;
            set
            {
                unlockerScores = value;
                IconPbx.IconColor = unlockerScores.Any() ? ActiveColor : InactiveColor;
                SubtitleLabel.ForeColor = unlockerScores.Any() ? ActiveColor : InactiveColor;
                SubtitleLabel.Text = unlockerScores.Any() ? "Achievement unlocked!" : "Pending challenge";
            }
        }

        public AchievementControl()
        {
            InitializeComponent();
        }

        private void OnMouseOver(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.AliceBlue;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Transparent;
        }

        private void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("\n", unlockerScores.Select(x => x.ToString())));
        }
    }
}
