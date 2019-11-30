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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FlpControlBox = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMax = new FontAwesome.Sharp.IconButton();
            this.BtnMin = new FontAwesome.Sharp.IconButton();
            this.Version = new System.Windows.Forms.Label();
            this.Repo = new System.Windows.Forms.LinkLabel();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.pGeneral = new System.Windows.Forms.Panel();
            this.PlayButton = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.AchievementsButton = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.TlpPrincipal.SuspendLayout();
            this.FlpControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.pGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.AllowDrop = true;
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TlpPrincipal.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpPrincipal.Controls.Add(this.FlpControlBox, 1, 0);
            this.TlpPrincipal.Controls.Add(this.Version, 0, 5);
            this.TlpPrincipal.Controls.Add(this.PlayButton, 0, 2);
            this.TlpPrincipal.Controls.Add(this.AchievementsButton, 0, 3);
            this.TlpPrincipal.Controls.Add(this.Repo, 0, 4);
            this.TlpPrincipal.Controls.Add(this.MainImage, 0, 1);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TlpPrincipal.RowCount = 6;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.Size = new System.Drawing.Size(384, 384);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.SeaGreen;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 5);
            this.LblTitulo.Size = new System.Drawing.Size(230, 40);
            this.LblTitulo.TabIndex = 17;
            this.LblTitulo.Text = "MAGIC STAIRCASE";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseDown);
            // 
            // FlpControlBox
            // 
            this.FlpControlBox.BackColor = System.Drawing.Color.SeaGreen;
            this.FlpControlBox.Controls.Add(this.BtnClose);
            this.FlpControlBox.Controls.Add(this.BtnMax);
            this.FlpControlBox.Controls.Add(this.BtnMin);
            this.FlpControlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpControlBox.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpControlBox.Location = new System.Drawing.Point(230, 0);
            this.FlpControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.FlpControlBox.Name = "FlpControlBox";
            this.FlpControlBox.Size = new System.Drawing.Size(154, 40);
            this.FlpControlBox.TabIndex = 15;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconSize = 30;
            this.BtnClose.Location = new System.Drawing.Point(114, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(40, 40);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // BtnMax
            // 
            this.BtnMax.Enabled = false;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMax.IconColor = System.Drawing.Color.White;
            this.BtnMax.IconSize = 30;
            this.BtnMax.Location = new System.Drawing.Point(74, 0);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Rotation = 0D;
            this.BtnMax.Size = new System.Drawing.Size(40, 40);
            this.BtnMax.TabIndex = 1;
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMaxClick);
            // 
            // BtnMin
            // 
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMin.IconColor = System.Drawing.Color.White;
            this.BtnMin.IconSize = 30;
            this.BtnMin.Location = new System.Drawing.Point(34, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Rotation = 0D;
            this.BtnMin.Size = new System.Drawing.Size(40, 40);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMinClick);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Version.Location = new System.Drawing.Point(20, 354);
            this.Version.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(190, 20);
            this.Version.TabIndex = 13;
            this.Version.Text = "Version";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Repo
            // 
            this.Repo.AutoSize = true;
            this.Repo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Repo.Location = new System.Drawing.Point(20, 334);
            this.Repo.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Repo.Name = "Repo";
            this.Repo.Size = new System.Drawing.Size(190, 20);
            this.Repo.TabIndex = 14;
            this.Repo.TabStop = true;
            this.Repo.Text = "Source code in github.com";
            this.Repo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Repo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Repo_LinkClicked);
            // 
            // MainImage
            // 
            this.TlpPrincipal.SetColumnSpan(this.MainImage, 2);
            this.MainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainImage.Image = global::MagicStaircase.Forms.Properties.Resources.main;
            this.MainImage.Location = new System.Drawing.Point(20, 50);
            this.MainImage.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(344, 134);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImage.TabIndex = 16;
            this.MainImage.TabStop = false;
            // 
            // pGeneral
            // 
            this.pGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGeneral.Controls.Add(this.TlpPrincipal);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(386, 386);
            this.pGeneral.TabIndex = 2;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.SeaGreen;
            this.TlpPrincipal.SetColumnSpan(this.PlayButton, 2);
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PlayButton.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.PlayButton.IconColor = System.Drawing.Color.White;
            this.PlayButton.IconSize = 40;
            this.PlayButton.Location = new System.Drawing.Point(20, 204);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Rotation = 0D;
            this.PlayButton.Size = new System.Drawing.Size(344, 50);
            this.PlayButton.TabIndex = 8;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // AchievementsButton
            // 
            this.AchievementsButton.BackColor = System.Drawing.Color.SeaGreen;
            this.TlpPrincipal.SetColumnSpan(this.AchievementsButton, 2);
            this.AchievementsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AchievementsButton.FlatAppearance.BorderSize = 0;
            this.AchievementsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AchievementsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AchievementsButton.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchievementsButton.ForeColor = System.Drawing.Color.White;
            this.AchievementsButton.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.AchievementsButton.IconColor = System.Drawing.Color.White;
            this.AchievementsButton.IconSize = 40;
            this.AchievementsButton.Location = new System.Drawing.Point(20, 274);
            this.AchievementsButton.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.AchievementsButton.Name = "AchievementsButton";
            this.AchievementsButton.Rotation = 0D;
            this.AchievementsButton.Size = new System.Drawing.Size(344, 50);
            this.AchievementsButton.TabIndex = 9;
            this.AchievementsButton.Text = "ACHIEVEMENTS";
            this.AchievementsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AchievementsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AchievementsButton.UseVisualStyleBackColor = false;
            this.AchievementsButton.Click += new System.EventHandler(this.BtnBestScores_Click);
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 386);
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
            this.FlpControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.pGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private CustomControls.CustomButton PlayButton;
        private CustomControls.CustomButton AchievementsButton;
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.LinkLabel Repo;
        private System.Windows.Forms.FlowLayoutPanel FlpControlBox;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMax;
        private FontAwesome.Sharp.IconButton BtnMin;
        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.Label LblTitulo;
    }
}