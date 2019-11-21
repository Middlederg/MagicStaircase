namespace MagicStaircase.Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.pDown2 = new System.Windows.Forms.Panel();
            this.CartaDown2 = new MagicStaircase.Forms.CustomControls.Carta();
            this.pDown1 = new System.Windows.Forms.Panel();
            this.CartaDown1 = new MagicStaircase.Forms.CustomControls.Carta();
            this.pUp2 = new System.Windows.Forms.Panel();
            this.CartaUp2 = new MagicStaircase.Forms.CustomControls.Carta();
            this.FlpMano = new System.Windows.Forms.FlowLayoutPanel();
            this.pUp1 = new System.Windows.Forms.Panel();
            this.CartaUp1 = new MagicStaircase.Forms.CustomControls.Carta();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FlpControlBox = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMax = new FontAwesome.Sharp.IconButton();
            this.BtnMin = new FontAwesome.Sharp.IconButton();
            this.FlpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnExit = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.BtnReset = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.BtnNext = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.LblPuntuacion = new System.Windows.Forms.Label();
            this.ToolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.T = new System.Windows.Forms.Timer(this.components);
            this.TlpPrincipal.SuspendLayout();
            this.pDown2.SuspendLayout();
            this.pDown1.SuspendLayout();
            this.pUp2.SuspendLayout();
            this.pUp1.SuspendLayout();
            this.FlpControlBox.SuspendLayout();
            this.FlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.AllowDrop = true;
            this.TlpPrincipal.ColumnCount = 4;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpPrincipal.Controls.Add(this.LblTiempo, 1, 4);
            this.TlpPrincipal.Controls.Add(this.pDown2, 3, 2);
            this.TlpPrincipal.Controls.Add(this.pDown1, 2, 2);
            this.TlpPrincipal.Controls.Add(this.pUp2, 1, 2);
            this.TlpPrincipal.Controls.Add(this.FlpMano, 0, 3);
            this.TlpPrincipal.Controls.Add(this.pUp1, 0, 2);
            this.TlpPrincipal.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpPrincipal.Controls.Add(this.FlpControlBox, 3, 0);
            this.TlpPrincipal.Controls.Add(this.FlpButtons, 2, 4);
            this.TlpPrincipal.Controls.Add(this.LblPuntuacion, 0, 4);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // pDown2
            // 
            this.pDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDown2.Controls.Add(this.CartaDown2);
            this.pDown2.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDown2.Location = new System.Drawing.Point(750, 60);
            this.pDown2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pDown2.Name = "pDown2";
            this.pDown2.Size = new System.Drawing.Size(100, 140);
            this.pDown2.TabIndex = 4;
            this.pDown2.Tag = "3";
            // 
            // CartaDown2
            // 
            this.CartaDown2.BackColor = System.Drawing.Color.White;
            this.CartaDown2.Direccion = MagicStaircase.Core.Model.Direction.Down;
            this.CartaDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaDown2.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.CartaDown2.FontSize = 40;
            this.CartaDown2.Location = new System.Drawing.Point(0, 0);
            this.CartaDown2.Margin = new System.Windows.Forms.Padding(10);
            this.CartaDown2.Name = "CartaDown2";
            this.CartaDown2.Numero = 99;
            this.CartaDown2.Size = new System.Drawing.Size(98, 138);
            this.CartaDown2.TabIndex = 1;
            this.CartaDown2.Text = "99";
            this.CartaDown2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pDown1
            // 
            this.pDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDown1.Controls.Add(this.CartaDown1);
            this.pDown1.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDown1.Location = new System.Drawing.Point(640, 60);
            this.pDown1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pDown1.Name = "pDown1";
            this.pDown1.Size = new System.Drawing.Size(100, 140);
            this.pDown1.TabIndex = 3;
            this.pDown1.Tag = "2";
            // 
            // CartaDown1
            // 
            this.CartaDown1.BackColor = System.Drawing.Color.White;
            this.CartaDown1.Direccion = MagicStaircase.Core.Model.Direction.Down;
            this.CartaDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaDown1.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.CartaDown1.FontSize = 40;
            this.CartaDown1.Location = new System.Drawing.Point(0, 0);
            this.CartaDown1.Margin = new System.Windows.Forms.Padding(10);
            this.CartaDown1.Name = "CartaDown1";
            this.CartaDown1.Numero = 99;
            this.CartaDown1.Size = new System.Drawing.Size(98, 138);
            this.CartaDown1.TabIndex = 1;
            this.CartaDown1.Text = "99";
            this.CartaDown1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pUp2
            // 
            this.pUp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUp2.Controls.Add(this.CartaUp2);
            this.pUp2.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pUp2.Location = new System.Drawing.Point(250, 60);
            this.pUp2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pUp2.Name = "pUp2";
            this.pUp2.Size = new System.Drawing.Size(100, 140);
            this.pUp2.TabIndex = 2;
            this.pUp2.Tag = "1";
            // 
            // CartaUp2
            // 
            this.CartaUp2.BackColor = System.Drawing.Color.White;
            this.CartaUp2.Direccion = MagicStaircase.Core.Model.Direction.Up;
            this.CartaUp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaUp2.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.CartaUp2.FontSize = 40;
            this.CartaUp2.Location = new System.Drawing.Point(0, 0);
            this.CartaUp2.Margin = new System.Windows.Forms.Padding(10);
            this.CartaUp2.Name = "CartaUp2";
            this.CartaUp2.Numero = 1;
            this.CartaUp2.Size = new System.Drawing.Size(98, 138);
            this.CartaUp2.TabIndex = 1;
            this.CartaUp2.Text = "1";
            this.CartaUp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // pUp1
            // 
            this.pUp1.AllowDrop = true;
            this.pUp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pUp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUp1.Controls.Add(this.CartaUp1);
            this.pUp1.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pUp1.Location = new System.Drawing.Point(140, 60);
            this.pUp1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pUp1.Name = "pUp1";
            this.pUp1.Size = new System.Drawing.Size(100, 140);
            this.pUp1.TabIndex = 1;
            this.pUp1.Tag = "0";
            // 
            // CartaUp1
            // 
            this.CartaUp1.BackColor = System.Drawing.Color.White;
            this.CartaUp1.Direccion = MagicStaircase.Core.Model.Direction.Up;
            this.CartaUp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaUp1.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.CartaUp1.FontSize = 40;
            this.CartaUp1.Location = new System.Drawing.Point(0, 0);
            this.CartaUp1.Margin = new System.Windows.Forms.Padding(10);
            this.CartaUp1.Name = "CartaUp1";
            this.CartaUp1.Numero = 1;
            this.CartaUp1.Size = new System.Drawing.Size(98, 138);
            this.CartaUp1.TabIndex = 0;
            this.CartaUp1.Text = "1";
            this.CartaUp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.ToolTipAyuda.SetToolTip(this.LblPuntuacion, "Puntuación actual (Número de cartas restantes)\r\nCuando no queden cartas, el juego" +
        " termina con victoria absoluta, por loq ue la máxima puntuación es 0");
            // 
            // T
            // 
            this.T.Enabled = true;
            this.T.Interval = 1000;
            this.T.Tick += new System.EventHandler(this.T_Tick);
            // 
            // FrmPrincipal
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
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Up and down cards";
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.pDown2.ResumeLayout(false);
            this.pDown1.ResumeLayout(false);
            this.pUp2.ResumeLayout(false);
            this.pUp1.ResumeLayout(false);
            this.FlpControlBox.ResumeLayout(false);
            this.FlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel FlpMano;
        private System.Windows.Forms.Panel pUp1;
        private System.Windows.Forms.Panel pDown2;
        private System.Windows.Forms.Panel pDown1;
        private System.Windows.Forms.Panel pUp2;
        private CustomControls.Carta CartaUp1;
        private CustomControls.Carta CartaDown1;
        private CustomControls.Carta CartaUp2;
        private CustomControls.Carta CartaDown2;
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
        private System.Windows.Forms.Timer T;
    }
}

