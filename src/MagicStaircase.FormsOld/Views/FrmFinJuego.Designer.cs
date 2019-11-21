namespace MagicStaircase.Forms
{
    partial class FrmFinJuego
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
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnExit = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.LblValoracion = new System.Windows.Forms.Label();
            this.LblPuntuacion = new System.Windows.Forms.Label();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.AllowDrop = true;
            this.TlpPrincipal.ColumnCount = 1;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Controls.Add(this.BtnExit, 0, 4);
            this.TlpPrincipal.Controls.Add(this.LblTiempo, 0, 2);
            this.TlpPrincipal.Controls.Add(this.LblValoracion, 0, 1);
            this.TlpPrincipal.Controls.Add(this.LblPuntuacion, 0, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TlpPrincipal.RowCount = 5;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TlpPrincipal.Size = new System.Drawing.Size(238, 144);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnExit.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.IconSize = 40;
            this.BtnExit.Location = new System.Drawing.Point(20, 84);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0D;
            this.BtnExit.Size = new System.Drawing.Size(198, 50);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTiempo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiempo.Location = new System.Drawing.Point(20, 54);
            this.LblTiempo.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(198, 20);
            this.LblTiempo.TabIndex = 12;
            this.LblTiempo.Text = "Tiempo";
            this.LblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValoracion
            // 
            this.LblValoracion.AutoSize = true;
            this.LblValoracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblValoracion.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValoracion.Location = new System.Drawing.Point(20, 34);
            this.LblValoracion.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.LblValoracion.Name = "LblValoracion";
            this.LblValoracion.Size = new System.Drawing.Size(198, 20);
            this.LblValoracion.TabIndex = 11;
            this.LblValoracion.Text = "Valoración";
            this.LblValoracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPuntuacion
            // 
            this.LblPuntuacion.AutoSize = true;
            this.LblPuntuacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPuntuacion.Location = new System.Drawing.Point(20, 0);
            this.LblPuntuacion.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.LblPuntuacion.Name = "LblPuntuacion";
            this.LblPuntuacion.Size = new System.Drawing.Size(198, 34);
            this.LblPuntuacion.TabIndex = 10;
            this.LblPuntuacion.Text = "Puntuación";
            this.LblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFinJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 144);
            this.ControlBox = false;
            this.Controls.Add(this.TlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFinJuego";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "End of game";
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.Label LblPuntuacion;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Label LblValoracion;
        private CustomControls.CustomButton BtnExit;
    }
}