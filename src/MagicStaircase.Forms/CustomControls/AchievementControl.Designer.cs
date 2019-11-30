namespace MagicStaircase.Forms.CustomControls
{
    partial class AchievementControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.IconPbx = new FontAwesome.Sharp.IconPictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Controls.Add(this.SubtitleLabel, 1, 1);
            this.Table.Controls.Add(this.IconPbx, 0, 0);
            this.Table.Controls.Add(this.NameLabel, 1, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Font = new System.Drawing.Font("Courier New", 9F);
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Size = new System.Drawing.Size(250, 45);
            this.Table.TabIndex = 0;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtitleLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.SubtitleLabel.Location = new System.Drawing.Point(47, 22);
            this.SubtitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 5);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(201, 18);
            this.SubtitleLabel.TabIndex = 2;
            this.SubtitleLabel.Text = "label2";
            this.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IconPbx
            // 
            this.IconPbx.BackColor = System.Drawing.Color.Transparent;
            this.IconPbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconPbx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconPbx.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.IconPbx.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconPbx.IconSize = 35;
            this.IconPbx.Location = new System.Drawing.Point(5, 5);
            this.IconPbx.Margin = new System.Windows.Forms.Padding(5);
            this.IconPbx.Name = "IconPbx";
            this.Table.SetRowSpan(this.IconPbx, 2);
            this.IconPbx.Size = new System.Drawing.Size(35, 35);
            this.IconPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPbx.TabIndex = 0;
            this.IconPbx.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Courier New", 12F);
            this.NameLabel.Location = new System.Drawing.Point(45, 5);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0, 5, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "label1";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameLabel.Click += new System.EventHandler(this.OnMouseOver);
            this.NameLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.NameLabel.MouseHover += new System.EventHandler(this.OnMouseOver);
            // 
            // AchievementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Table);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AchievementControl";
            this.Size = new System.Drawing.Size(250, 45);
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        private FontAwesome.Sharp.IconPictureBox IconPbx;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}
