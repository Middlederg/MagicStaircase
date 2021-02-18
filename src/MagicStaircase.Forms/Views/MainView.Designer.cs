namespace MagicStaircase.Forms
{
    partial class MainView
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.FlpMano = new System.Windows.Forms.FlowLayoutPanel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FlpControlBox = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMax = new FontAwesome.Sharp.IconButton();
            this.BtnMin = new FontAwesome.Sharp.IconButton();
            this.FlpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.LblPuntuacion = new System.Windows.Forms.Label();
            this.ToolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BtnExit = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.BtnReset = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.BtnNext = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.pila1 = new MagicStaircase.Forms.CustomControls.Pila();
            this.pila2 = new MagicStaircase.Forms.CustomControls.Pila();
            this.pila3 = new MagicStaircase.Forms.CustomControls.Pila();
            this.pila4 = new MagicStaircase.Forms.CustomControls.Pila();
            this.TlpPrincipal.SuspendLayout();
            this.FlpControlBox.SuspendLayout();
            this.FlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.AllowDrop = true;
            this.TlpPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TlpPrincipal.ColumnCount = 4;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpPrincipal.Controls.Add(this.pila1, 0, 2);
            this.TlpPrincipal.Controls.Add(this.LblTiempo, 1, 4);
            this.TlpPrincipal.Controls.Add(this.FlpMano, 0, 3);
            this.TlpPrincipal.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpPrincipal.Controls.Add(this.FlpControlBox, 3, 0);
            this.TlpPrincipal.Controls.Add(this.FlpButtons, 2, 4);
            this.TlpPrincipal.Controls.Add(this.LblPuntuacion, 0, 4);
            this.TlpPrincipal.Controls.Add(this.pila2, 1, 2);
            this.TlpPrincipal.Controls.Add(this.pila3, 2, 2);
            this.TlpPrincipal.Controls.Add(this.pila4, 3, 2);
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.TlpPrincipal.RowCount = 5;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TlpPrincipal.Size = new System.Drawing.Size(1000, 500);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTiempo.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiempo.Location = new System.Drawing.Point(290, 440);
            this.LblTiempo.Margin = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(170, 30);
            this.LblTiempo.TabIndex = 11;
            this.LblTiempo.Text = "00:00";
            this.LblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTipAyuda.SetToolTip(this.LblTiempo, "Puntuación actual (Número de cartas restantes)\r\nCuando no queden cartas, el juego" +
        " termina con victoria absoluta, por loq ue la máxima puntuación es 0");
            // 
            // FlpMano
            // 
            this.TlpPrincipal.SetColumnSpan(this.FlpMano, 4);
            this.FlpMano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpMano.Location = new System.Drawing.Point(20, 245);
            this.FlpMano.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.FlpMano.Name = "FlpMano";
            this.FlpMano.Size = new System.Drawing.Size(980, 185);
            this.FlpMano.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.SeaGreen;
            this.TlpPrincipal.SetColumnSpan(this.LblTitulo, 3);
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LblTitulo.Size = new System.Drawing.Size(750, 40);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Magic staircase";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.FlpControlBox.Location = new System.Drawing.Point(750, 0);
            this.FlpControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.FlpControlBox.Name = "FlpControlBox";
            this.FlpControlBox.Size = new System.Drawing.Size(250, 40);
            this.FlpControlBox.TabIndex = 7;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconSize = 30;
            this.BtnClose.Location = new System.Drawing.Point(210, 0);
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
            this.BtnMax.Location = new System.Drawing.Point(170, 0);
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
            this.BtnMin.Location = new System.Drawing.Point(130, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Rotation = 0D;
            this.BtnMin.Size = new System.Drawing.Size(40, 40);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMinClick);
            // 
            // FlpButtons
            // 
            this.TlpPrincipal.SetColumnSpan(this.FlpButtons, 2);
            this.FlpButtons.Controls.Add(this.BtnExit);
            this.FlpButtons.Controls.Add(this.BtnReset);
            this.FlpButtons.Controls.Add(this.BtnNext);
            this.FlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpButtons.Location = new System.Drawing.Point(500, 430);
            this.FlpButtons.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.FlpButtons.Name = "FlpButtons";
            this.FlpButtons.Size = new System.Drawing.Size(480, 50);
            this.FlpButtons.TabIndex = 9;
            // 
            // LblPuntuacion
            // 
            this.LblPuntuacion.AutoSize = true;
            this.LblPuntuacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPuntuacion.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntuacion.Location = new System.Drawing.Point(20, 430);
            this.LblPuntuacion.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LblPuntuacion.Name = "LblPuntuacion";
            this.LblPuntuacion.Size = new System.Drawing.Size(230, 50);
            this.LblPuntuacion.TabIndex = 10;
            this.LblPuntuacion.Text = "Puntuación";
            this.LblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTipAyuda.SetToolTip(this.LblPuntuacion, "Current Score, from 3 to 100");
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnExit.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.IconSize = 40;
            this.BtnExit.Location = new System.Drawing.Point(330, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0D;
            this.BtnExit.Size = new System.Drawing.Size(150, 50);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnReset.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.BtnReset.IconColor = System.Drawing.Color.White;
            this.BtnReset.IconSize = 40;
            this.BtnReset.Location = new System.Drawing.Point(170, 0);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Rotation = 0D;
            this.BtnReset.Size = new System.Drawing.Size(150, 50);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnNext.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.BtnNext.IconColor = System.Drawing.Color.White;
            this.BtnNext.IconSize = 40;
            this.BtnNext.Location = new System.Drawing.Point(10, 0);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Rotation = 0D;
            this.BtnNext.Size = new System.Drawing.Size(150, 50);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = "Next";
            this.BtnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // pila1
            // 
            this.pila1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pila1.BackColor = System.Drawing.Color.White;
            this.pila1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pila1.Font = new System.Drawing.Font("Courier New", 39.75F);
            this.pila1.FontSize = 20;
            this.pila1.Location = new System.Drawing.Point(140, 70);
            this.pila1.Margin = new System.Windows.Forms.Padding(10);
            this.pila1.Name = "pila1";
            this.pila1.OnCardPlaced = null;
            this.pila1.Size = new System.Drawing.Size(100, 140);
            this.pila1.TabIndex = 0;
            this.pila1.Text = "pila1";
            this.pila1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pila2
            // 
            this.pila2.BackColor = System.Drawing.Color.White;
            this.pila2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pila2.Font = new System.Drawing.Font("Courier New", 39.75F);
            this.pila2.FontSize = 20;
            this.pila2.Location = new System.Drawing.Point(260, 70);
            this.pila2.Margin = new System.Windows.Forms.Padding(10);
            this.pila2.Name = "pila2";
            this.pila2.OnCardPlaced = null;
            this.pila2.Size = new System.Drawing.Size(100, 140);
            this.pila2.TabIndex = 12;
            this.pila2.Text = "pila2";
            this.pila2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pila3
            // 
            this.pila3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pila3.BackColor = System.Drawing.Color.White;
            this.pila3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pila3.Font = new System.Drawing.Font("Courier New", 39.75F);
            this.pila3.FontSize = 20;
            this.pila3.Location = new System.Drawing.Point(640, 70);
            this.pila3.Margin = new System.Windows.Forms.Padding(10);
            this.pila3.Name = "pila3";
            this.pila3.OnCardPlaced = null;
            this.pila3.Size = new System.Drawing.Size(100, 140);
            this.pila3.TabIndex = 13;
            this.pila3.Text = "pila3";
            this.pila3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pila4
            // 
            this.pila4.BackColor = System.Drawing.Color.White;
            this.pila4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pila4.Font = new System.Drawing.Font("Courier New", 39.75F);
            this.pila4.FontSize = 20;
            this.pila4.Location = new System.Drawing.Point(760, 70);
            this.pila4.Margin = new System.Windows.Forms.Padding(10);
            this.pila4.Name = "pila4";
            this.pila4.OnCardPlaced = null;
            this.pila4.Size = new System.Drawing.Size(100, 140);
            this.pila4.TabIndex = 14;
            this.pila4.Text = "pila4";
            this.pila4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.TlpPrincipal);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Up and down cards";
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.FlpControlBox.ResumeLayout(false);
            this.FlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel FlpMano;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.FlowLayoutPanel FlpControlBox;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMax;
        private FontAwesome.Sharp.IconButton BtnMin;
        private CustomControls.CustomButton BtnNext;
        private System.Windows.Forms.FlowLayoutPanel FlpButtons;
        private CustomControls.CustomButton BtnExit;
        private CustomControls.CustomButton BtnReset;
        private System.Windows.Forms.Label LblPuntuacion;
        private System.Windows.Forms.ToolTip ToolTipAyuda;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Timer Timer;
        private CustomControls.Pila pila1;
        private CustomControls.Pila pila2;
        private CustomControls.Pila pila3;
        private CustomControls.Pila pila4;
    }
}

