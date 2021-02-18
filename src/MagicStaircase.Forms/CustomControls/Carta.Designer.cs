namespace MagicStaircase.Forms.CustomControls
{
    partial class Carta
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
            this.components = new System.ComponentModel.Container();
            this.ToolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Carta
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Font = new System.Drawing.Font("Courier New", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(100, 140);
            this.Text = "1";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTipAyuda;
    }
}
