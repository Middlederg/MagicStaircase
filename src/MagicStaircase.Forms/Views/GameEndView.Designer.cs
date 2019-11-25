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
            this.BtnOk = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.BtnCancel = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.TlpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTiempo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiempo.Location = new System.Drawing.Point(153, 12);
            this.LblTiempo.Margin = new System.Windows.Forms.Padding(0);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(141, 20);
            this.LblTiempo.TabIndex = 12;
            this.LblTiempo.Text = "Tiempo";
            this.LblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValoracion
            // 
            this.LblValoracion.AutoSize = true;
            this.TlpGeneral.SetColumnSpan(this.LblValoracion, 2);
            this.LblValoracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblValoracion.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValoracion.Location = new System.Drawing.Point(13, 32);
            this.LblValoracion.Margin = new System.Windows.Forms.Padding(0);
            this.LblValoracion.Name = "LblValoracion";
            this.LblValoracion.Size = new System.Drawing.Size(281, 20);
            this.LblValoracion.TabIndex = 11;
            this.LblValoracion.Text = "Valoración";
            this.LblValoracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPuntuacion
            // 
            this.LblPuntuacion.AutoSize = true;
            this.LblPuntuacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPuntuacion.Location = new System.Drawing.Point(13, 12);
            this.LblPuntuacion.Margin = new System.Windows.Forms.Padding(0);
            this.LblPuntuacion.Name = "LblPuntuacion";
            this.LblPuntuacion.Size = new System.Drawing.Size(140, 20);
            this.LblPuntuacion.TabIndex = 10;
            this.LblPuntuacion.Text = "Puntuación";
            this.LblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.ColumnCount = 2;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGeneral.Controls.Add(this.BtnOk, 0, 3);
            this.TlpGeneral.Controls.Add(this.BtnCancel, 0, 3);
            this.TlpGeneral.Controls.Add(this.LblPuntuacion, 0, 0);
            this.TlpGeneral.Controls.Add(this.NameTextbox, 0, 2);
            this.TlpGeneral.Controls.Add(this.LblTiempo, 1, 0);
            this.TlpGeneral.Controls.Add(this.LblValoracion, 0, 1);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TlpGeneral.RowCount = 4;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Size = new System.Drawing.Size(307, 130);
            this.TlpGeneral.TabIndex = 13;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnOk.IconColor = System.Drawing.Color.White;
            this.BtnOk.IconSize = 28;
            this.BtnOk.Location = new System.Drawing.Point(13, 87);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(130, 31);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancel.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCancel.IconColor = System.Drawing.Color.White;
            this.BtnCancel.IconSize = 28;
            this.BtnCancel.Location = new System.Drawing.Point(163, 87);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Rotation = 0D;
            this.BtnCancel.Size = new System.Drawing.Size(131, 31);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // NameTextbox
            // 
            this.TlpGeneral.SetColumnSpan(this.NameTextbox, 2);
            this.NameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.Location = new System.Drawing.Point(13, 52);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(281, 26);
            this.NameTextbox.TabIndex = 2;
            // 
            // GameEndView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 130);
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
        private CustomControls.CustomButton BtnCancel;
        private System.Windows.Forms.TextBox NameTextbox;
    }
}