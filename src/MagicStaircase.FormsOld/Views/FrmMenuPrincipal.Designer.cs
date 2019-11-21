namespace MagicStaircase.Forms
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNext = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnReset = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.BtnExit = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.Lbx = new System.Windows.Forms.ListBox();
            this.MenuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renombrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pGeneral = new System.Windows.Forms.Panel();
            this.Version = new System.Windows.Forms.Label();
            this.Repo = new System.Windows.Forms.LinkLabel();
            this.TlpPrincipal.SuspendLayout();
            this.MenuListView.SuspendLayout();
            this.pGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.AllowDrop = true;
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TlpPrincipal.Controls.Add(this.Version, 1, 4);
            this.TlpPrincipal.Controls.Add(this.BtnNext, 0, 1);
            this.TlpPrincipal.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpPrincipal.Controls.Add(this.BtnReset, 0, 2);
            this.TlpPrincipal.Controls.Add(this.BtnExit, 0, 3);
            this.TlpPrincipal.Controls.Add(this.Lbx, 1, 1);
            this.TlpPrincipal.Controls.Add(this.Repo, 0, 4);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TlpPrincipal.RowCount = 5;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.Size = new System.Drawing.Size(495, 280);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnNext.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.BtnNext.IconColor = System.Drawing.Color.White;
            this.BtnNext.IconSize = 40;
            this.BtnNext.Location = new System.Drawing.Point(20, 70);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Rotation = 0D;
            this.BtnNext.Size = new System.Drawing.Size(257, 43);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = "PLAY";
            this.BtnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.TlpPrincipal.SetColumnSpan(this.LblTitulo, 2);
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.SeaGreen;
            this.LblTitulo.Location = new System.Drawing.Point(20, 10);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LblTitulo.Size = new System.Drawing.Size(455, 40);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Magic staircase";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnReset.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.IconChar = FontAwesome.Sharp.IconChar.PenFancy;
            this.BtnReset.IconColor = System.Drawing.Color.White;
            this.BtnReset.IconSize = 40;
            this.BtnReset.Location = new System.Drawing.Point(20, 133);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Rotation = 0D;
            this.BtnReset.Size = new System.Drawing.Size(257, 43);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "BEST SCORES";
            this.BtnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
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
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.IconSize = 40;
            this.BtnExit.Location = new System.Drawing.Point(20, 196);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0D;
            this.BtnExit.Size = new System.Drawing.Size(257, 43);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Lbx
            // 
            this.Lbx.ContextMenuStrip = this.MenuListView;
            this.Lbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbx.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx.FormattingEnabled = true;
            this.Lbx.ItemHeight = 15;
            this.Lbx.Location = new System.Drawing.Point(297, 70);
            this.Lbx.Margin = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.Lbx.Name = "Lbx";
            this.TlpPrincipal.SetRowSpan(this.Lbx, 3);
            this.Lbx.Size = new System.Drawing.Size(178, 169);
            this.Lbx.TabIndex = 11;
            this.Lbx.SelectedIndexChanged += new System.EventHandler(this.Lbx_SelectedIndexChanged);
            // 
            // MenuListView
            // 
            this.MenuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPerfilToolStripMenuItem,
            this.renombrarToolStripMenuItem,
            this.eliminarPerfilToolStripMenuItem});
            this.MenuListView.Name = "MenuListView";
            this.MenuListView.Size = new System.Drawing.Size(155, 70);
            // 
            // nuevoPerfilToolStripMenuItem
            // 
            this.nuevoPerfilToolStripMenuItem.Name = "nuevoPerfilToolStripMenuItem";
            this.nuevoPerfilToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nuevoPerfilToolStripMenuItem.Text = "New profile";
            this.nuevoPerfilToolStripMenuItem.Click += new System.EventHandler(this.NuevoPerfilToolStripMenuItem_Click);
            // 
            // renombrarToolStripMenuItem
            // 
            this.renombrarToolStripMenuItem.Name = "renombrarToolStripMenuItem";
            this.renombrarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.renombrarToolStripMenuItem.Text = "Rename profile";
            this.renombrarToolStripMenuItem.Click += new System.EventHandler(this.RenombrarToolStripMenuItem_Click);
            // 
            // eliminarPerfilToolStripMenuItem
            // 
            this.eliminarPerfilToolStripMenuItem.Name = "eliminarPerfilToolStripMenuItem";
            this.eliminarPerfilToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.eliminarPerfilToolStripMenuItem.Text = "Delete profile";
            this.eliminarPerfilToolStripMenuItem.Click += new System.EventHandler(this.EliminarPerfilToolStripMenuItem_Click);
            // 
            // pGeneral
            // 
            this.pGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGeneral.Controls.Add(this.TlpPrincipal);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(497, 282);
            this.pGeneral.TabIndex = 2;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Version.Location = new System.Drawing.Point(297, 249);
            this.Version.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(178, 21);
            this.Version.TabIndex = 13;
            this.Version.Text = "Version";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Repo
            // 
            this.Repo.AutoSize = true;
            this.Repo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Repo.Location = new System.Drawing.Point(20, 249);
            this.Repo.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Repo.Name = "Repo";
            this.Repo.Size = new System.Drawing.Size(277, 21);
            this.Repo.TabIndex = 14;
            this.Repo.TabStop = true;
            this.Repo.Text = "Source code in github.com";
            this.Repo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Repo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Repo_LinkClicked);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 282);
            this.ControlBox = false;
            this.Controls.Add(this.pGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.MenuListView.ResumeLayout(false);
            this.pGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private CustomControls.CustomButton BtnNext;
        private System.Windows.Forms.Label LblTitulo;
        private CustomControls.CustomButton BtnReset;
        private CustomControls.CustomButton BtnExit;
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.ListBox Lbx;
        private System.Windows.Forms.ContextMenuStrip MenuListView;
        private System.Windows.Forms.ToolStripMenuItem nuevoPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renombrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPerfilToolStripMenuItem;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.LinkLabel Repo;
    }
}