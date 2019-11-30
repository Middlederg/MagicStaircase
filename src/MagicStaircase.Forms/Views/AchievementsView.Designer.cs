namespace MagicStaircase.Forms
{
    partial class AchievementsView
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
            this.TlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FlpControlBox = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMax = new FontAwesome.Sharp.IconButton();
            this.BtnMin = new FontAwesome.Sharp.IconButton();
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.TlpGeneral.SuspendLayout();
            this.FlpControlBox.SuspendLayout();
            this.PanelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.ColumnCount = 2;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGeneral.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpGeneral.Controls.Add(this.FlpControlBox, 1, 0);
            this.TlpGeneral.Controls.Add(this.Flp, 0, 1);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.RowCount = 2;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGeneral.Size = new System.Drawing.Size(657, 471);
            this.TlpGeneral.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.SeaGreen;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LblTitulo.Size = new System.Drawing.Size(328, 32);
            this.LblTitulo.TabIndex = 9;
            this.LblTitulo.Text = "Achievements";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseDown);
            // 
            // FlpControlBox
            // 
            this.FlpControlBox.BackColor = System.Drawing.Color.SeaGreen;
            this.FlpControlBox.Controls.Add(this.BtnClose);
            this.FlpControlBox.Controls.Add(this.BtnMax);
            this.FlpControlBox.Controls.Add(this.BtnMin);
            this.FlpControlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpControlBox.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpControlBox.Location = new System.Drawing.Point(328, 0);
            this.FlpControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.FlpControlBox.Name = "FlpControlBox";
            this.FlpControlBox.Size = new System.Drawing.Size(329, 32);
            this.FlpControlBox.TabIndex = 8;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconSize = 30;
            this.BtnClose.Location = new System.Drawing.Point(297, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(32, 32);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMax.IconColor = System.Drawing.Color.White;
            this.BtnMax.IconSize = 30;
            this.BtnMax.Location = new System.Drawing.Point(265, 0);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Rotation = 0D;
            this.BtnMax.Size = new System.Drawing.Size(32, 32);
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
            this.BtnMin.Location = new System.Drawing.Point(233, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Rotation = 0D;
            this.BtnMin.Size = new System.Drawing.Size(32, 32);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMinClick);
            // 
            // Flp
            // 
            this.TlpGeneral.SetColumnSpan(this.Flp, 2);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(10, 42);
            this.Flp.Margin = new System.Windows.Forms.Padding(10);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(637, 419);
            this.Flp.TabIndex = 2;
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGeneral.Controls.Add(this.TlpGeneral);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(659, 473);
            this.PanelGeneral.TabIndex = 2;
            // 
            // AchievementsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 473);
            this.Controls.Add(this.PanelGeneral);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AchievementsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Achievements";
            this.TlpGeneral.ResumeLayout(false);
            this.TlpGeneral.PerformLayout();
            this.FlpControlBox.ResumeLayout(false);
            this.PanelGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private System.Windows.Forms.FlowLayoutPanel Flp;
        private System.Windows.Forms.FlowLayoutPanel FlpControlBox;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMax;
        private FontAwesome.Sharp.IconButton BtnMin;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PanelGeneral;
    }
}