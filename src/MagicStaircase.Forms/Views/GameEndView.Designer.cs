namespace MagicStaircase.Forms
{
    partial class GameEndView
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
            this.LblTiempo = new System.Windows.Forms.Label();
            this.LblValoracion = new System.Windows.Forms.Label();
            this.LblPuntuacion = new System.Windows.Forms.Label();
            this.TlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.AchievementsTitleLabel = new System.Windows.Forms.Label();
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.BtnOk = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.TlpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTiempo.Location = new System.Drawing.Point(13, 67);
            this.LblTiempo.Margin = new System.Windows.Forms.Padding(0);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(100, 25);
            this.LblTiempo.TabIndex = 12;
            this.LblTiempo.Text = "Tiempo";
            // 
            // LblValoracion
            // 
            this.LblValoracion.AutoSize = true;
            this.LblValoracion.BackColor = System.Drawing.Color.Linen;
            this.LblValoracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TlpGeneral.SetColumnSpan(this.LblValoracion, 2);
            this.LblValoracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblValoracion.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValoracion.Location = new System.Drawing.Point(13, 12);
            this.LblValoracion.Margin = new System.Windows.Forms.Padding(0);
            this.LblValoracion.Name = "LblValoracion";
            this.LblValoracion.Size = new System.Drawing.Size(358, 30);
            this.LblValoracion.TabIndex = 11;
            this.LblValoracion.Text = "Valoración";
            this.LblValoracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPuntuacion
            // 
            this.LblPuntuacion.AutoSize = true;
            this.LblPuntuacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPuntuacion.Location = new System.Drawing.Point(13, 42);
            this.LblPuntuacion.Margin = new System.Windows.Forms.Padding(0);
            this.LblPuntuacion.Name = "LblPuntuacion";
            this.LblPuntuacion.Size = new System.Drawing.Size(100, 25);
            this.LblPuntuacion.TabIndex = 10;
            this.LblPuntuacion.Text = "Puntuación";
            this.LblPuntuacion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.ColumnCount = 2;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Controls.Add(this.label1, 0, 3);
            this.TlpGeneral.Controls.Add(this.BtnOk, 0, 5);
            this.TlpGeneral.Controls.Add(this.LblPuntuacion, 0, 1);
            this.TlpGeneral.Controls.Add(this.NameTextbox, 0, 4);
            this.TlpGeneral.Controls.Add(this.LblTiempo, 0, 2);
            this.TlpGeneral.Controls.Add(this.LblValoracion, 0, 0);
            this.TlpGeneral.Controls.Add(this.AchievementsTitleLabel, 0, 6);
            this.TlpGeneral.Controls.Add(this.Flp, 0, 7);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TlpGeneral.RowCount = 8;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Size = new System.Drawing.Size(384, 380);
            this.TlpGeneral.TabIndex = 13;
            // 
            // AchievementsTitleLabel
            // 
            this.AchievementsTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AchievementsTitleLabel.AutoSize = true;
            this.TlpGeneral.SetColumnSpan(this.AchievementsTitleLabel, 2);
            this.AchievementsTitleLabel.Location = new System.Drawing.Point(23, 203);
            this.AchievementsTitleLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AchievementsTitleLabel.Name = "AchievementsTitleLabel";
            this.AchievementsTitleLabel.Size = new System.Drawing.Size(175, 14);
            this.AchievementsTitleLabel.TabIndex = 15;
            this.AchievementsTitleLabel.Text = "No achievements unlocked";
            this.AchievementsTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Flp
            // 
            this.Flp.AutoScroll = true;
            this.TlpGeneral.SetColumnSpan(this.Flp, 2);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(13, 217);
            this.Flp.Margin = new System.Windows.Forms.Padding(0);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(358, 151);
            this.Flp.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.TlpGeneral.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Insert your name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextbox
            // 
            this.TlpGeneral.SetColumnSpan(this.NameTextbox, 2);
            this.NameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.Location = new System.Drawing.Point(13, 112);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(358, 26);
            this.NameTextbox.TabIndex = 2;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.SeaGreen;
            this.TlpGeneral.SetColumnSpan(this.BtnOk, 2);
            this.BtnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnOk.IconColor = System.Drawing.Color.White;
            this.BtnOk.IconSize = 28;
            this.BtnOk.Location = new System.Drawing.Point(13, 147);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(358, 40);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // GameEndView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 380);
            this.ControlBox = false;
            this.Controls.Add(this.TlpGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameEndView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "End of game";
            this.Load += new System.EventHandler(this.OnLoad);
            this.TlpGeneral.ResumeLayout(false);
            this.TlpGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblPuntuacion;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Label LblValoracion;
        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private CustomControls.CustomButton BtnOk;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Flp;
        private System.Windows.Forms.Label AchievementsTitleLabel;
    }
}