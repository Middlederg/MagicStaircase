using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicStaircase.Forms
{
    public partial class InputView : Form
    {
        public string Caption { set => Text = value; }
        public string Contenido
        {
            get { return TbxTexto?.Text?.Trim(); }
            set { TbxTexto.Text = value; }
        }

        public InputView()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxTexto.Text))
            {
                MessageBox.Show(this, "Profile name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
