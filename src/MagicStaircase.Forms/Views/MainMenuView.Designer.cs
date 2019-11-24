namespace MagicStaircase.Forms
{
    partial class MainMenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuView));
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.Version = new System.Windows.Forms.Label();
            this.PlayButton = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.AchievementsButton = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.ExitButton = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.Repo = new System.Windows.Forms.LinkLabel();
            this.pGeneral = new System.Windows.Forms.Panel();
            this.TlpPrincipal.SuspendLayout();
            this.pGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.AllowDrop = true;
            this.TlpPrincipal.ColumnCount = 1;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TlpPrincipal.Controls.Add(this.Version, 0, 5);
            this.TlpPrincipal.Controls.Add(this.PlayButton, 0, 1);
            this.TlpPrincipal.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpPrincipal.Controls.Add(this.AchievementsButton, 0, 2);
            this.TlpPrincipal.Controls.Add(this.ExitButton, 0, 3);
            this.TlpPrincipal.Controls.Add(this.Repo, 0, 4);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TlpPrincipal.RowCount = 6;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.Size = new System.Drawing.Size(385, 304);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Version.Location = new System.Drawing.Point(20, 272);
            this.Version.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(345, 22);
            this.Version.TabIndex = 13;
            this.Version.Text = "Version";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.SeaGreen;
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PlayButton.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.PlayButton.IconColor = System.Drawing.Color.White;
            this.PlayButton.IconSize = 40;
            this.PlayButton.Location = new System.Drawing.Point(20, 70);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Rotation = 0D;
            this.PlayButton.Size = new System.Drawing.Size(345, 44);
            this.PlayButton.TabIndex = 8;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.SeaGreen;
            this.LblTitulo.Location = new System.Drawing.Point(20, 10);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LblTitulo.Size = new System.Drawing.Size(345, 40);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Magic staircase";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AchievementsButton
            // 
            this.AchievementsButton.BackColor = System.Drawing.Color.SeaGreen;
            this.AchievementsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AchievementsButton.FlatAppearance.BorderSize = 0;
            this.AchievementsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AchievementsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AchievementsButton.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchievementsButton.ForeColor = System.Drawing.Color.White;
            this.AchievementsButton.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.AchievementsButton.IconColor = System.Drawing.Color.White;
            this.AchievementsButton.IconSize = 40;
            this.AchievementsButton.Location = new System.Drawing.Point(20, 134);
            this.AchievementsButton.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.AchievementsButton.Name = "AchievementsButton";
            this.AchievementsButton.Rotation = 0D;
            this.AchievementsButton.Size = new System.Drawing.Size(345, 44);
            this.AchievementsButton.TabIndex = 9;
            this.AchievementsButton.Text = "ACHIEVEMENTS";
            this.AchievementsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AchievementsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AchievementsButton.UseVisualStyleBackColor = false;
            this.AchievementsButton.Click += new System.EventHandler(this.BtnBestScores_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ExitButton.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.IconSize = 40;
            this.ExitButton.Location = new System.Drawing.Point(20, 198);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Rotation = 0D;
            this.ExitButton.Size = new System.Drawing.Size(345, 44);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Repo
            // 
            this.Repo.AutoSize = true;
            this.Repo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Repo.Location = new System.Drawing.Point(20, 252);
            this.Repo.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Repo.Name = "Repo";
            this.Repo.Size = new System.Drawing.Size(345, 20);
            this.Repo.TabIndex = 14;
            this.Repo.TabStop = true;
            this.Repo.Text = "Source code in github.com";
            this.Repo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Repo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Repo_LinkClicked);
            // 
            // pGeneral
            // 
            this.pGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGeneral.Controls.Add(this.TlpPrincipal);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(387, 306);
            this.pGeneral.TabIndex = 2;
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 306);
            this.ControlBox = false;
            this.Controls.Add(this.pGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.OnLoad);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.pGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private CustomControls.CustomButton PlayButton;
        private System.Windows.Forms.Label LblTitulo;
        private CustomControls.CustomButton AchievementsButton;
        private CustomControls.CustomButton ExitButton;
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.LinkLabel Repo;
    }
}