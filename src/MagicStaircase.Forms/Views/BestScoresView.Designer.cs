namespace MagicStaircase.Forms
{
    partial class BestScoresView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lvw = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.pBotones = new System.Windows.Forms.Panel();
            this.BtnResetScores = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.BtnAchievements = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.TlpGeneral.SuspendLayout();
            this.pBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lvw
            // 
            this.Lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lvw.FullRowSelect = true;
            this.Lvw.GridLines = true;
            this.Lvw.HideSelection = false;
            this.Lvw.Location = new System.Drawing.Point(10, 50);
            this.Lvw.Margin = new System.Windows.Forms.Padding(0);
            this.Lvw.MultiSelect = false;
            this.Lvw.Name = "Lvw";
            this.Lvw.Size = new System.Drawing.Size(511, 226);
            this.Lvw.TabIndex = 0;
            this.Lvw.UseCompatibleStateImageBehavior = false;
            this.Lvw.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 80;
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.ColumnCount = 1;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Controls.Add(this.Lvw, 0, 1);
            this.TlpGeneral.Controls.Add(this.pBotones, 0, 0);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.Padding = new System.Windows.Forms.Padding(10);
            this.TlpGeneral.RowCount = 2;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Size = new System.Drawing.Size(531, 286);
            this.TlpGeneral.TabIndex = 1;
            // 
            // pBotones
            // 
            this.pBotones.Controls.Add(this.BtnResetScores);
            this.pBotones.Controls.Add(this.BtnAchievements);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBotones.Location = new System.Drawing.Point(10, 10);
            this.pBotones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(511, 35);
            this.pBotones.TabIndex = 1;
            // 
            // BtnResetScores
            // 
            this.BtnResetScores.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnResetScores.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnResetScores.FlatAppearance.BorderSize = 0;
            this.BtnResetScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetScores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnResetScores.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetScores.ForeColor = System.Drawing.Color.White;
            this.BtnResetScores.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.BtnResetScores.IconColor = System.Drawing.Color.White;
            this.BtnResetScores.IconSize = 28;
            this.BtnResetScores.Location = new System.Drawing.Point(476, 0);
            this.BtnResetScores.Margin = new System.Windows.Forms.Padding(0);
            this.BtnResetScores.Name = "BtnResetScores";
            this.BtnResetScores.Rotation = 0D;
            this.BtnResetScores.Size = new System.Drawing.Size(35, 35);
            this.BtnResetScores.TabIndex = 1;
            this.BtnResetScores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnResetScores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnResetScores.UseVisualStyleBackColor = false;
            this.BtnResetScores.Click += new System.EventHandler(this.BtnResetScores_Click);
            // 
            // BtnAchievements
            // 
            this.BtnAchievements.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAchievements.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAchievements.FlatAppearance.BorderSize = 0;
            this.BtnAchievements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAchievements.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAchievements.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAchievements.ForeColor = System.Drawing.Color.Black;
            this.BtnAchievements.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.BtnAchievements.IconColor = System.Drawing.Color.Black;
            this.BtnAchievements.IconSize = 28;
            this.BtnAchievements.Location = new System.Drawing.Point(0, 0);
            this.BtnAchievements.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAchievements.Name = "BtnAchievements";
            this.BtnAchievements.Rotation = 0D;
            this.BtnAchievements.Size = new System.Drawing.Size(198, 35);
            this.BtnAchievements.TabIndex = 0;
            this.BtnAchievements.Text = "Achievements";
            this.BtnAchievements.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAchievements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAchievements.UseVisualStyleBackColor = false;
            this.BtnAchievements.Click += new System.EventHandler(this.BtnAchievements_Click);
            // 
            // BestScoresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 286);
            this.Controls.Add(this.TlpGeneral);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BestScoresView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Achievements";
            this.TlpGeneral.ResumeLayout(false);
            this.pBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lvw;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private System.Windows.Forms.Panel pBotones;
        private CustomControls.CustomButton BtnResetScores;
        private CustomControls.CustomButton BtnAchievements;
    }
}