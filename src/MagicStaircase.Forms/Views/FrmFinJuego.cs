using FontAwesome.Sharp;
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
    public partial class FrmFinJuego : Form
    {
        public FrmFinJuego(int puntuacion, int segundos)
        {
            InitializeComponent();
            Icon = System.Drawing.Icon.FromHandle(IconChar.HourglassEnd.ToBitmap(98, Color.Black).GetHicon());
            LblPuntuacion.Text = $"Score: {puntuacion}";
            LblValoracion.Text = Valoracion(puntuacion);
            var minutos = ((int)new TimeSpan(0, 0, segundos).TotalMinutes);
            LblTiempo.Text = $"{minutos}:{segundos - (minutos * 60)}";
        }

        private string Valoracion(int puntuacion)
        {
            if (puntuacion >= 100 ) return "¡¡Best score ever!!";
            if (puntuacion > 95) return "¡¡Magnifique!!";
            if (puntuacion > 90) return "¡Excelent!";
            if (puntuacion > 85) return "¡Well done!";
            if (puntuacion > 80) return "Not bad";
            return "You have to get better...";
        }
        private void BtnExit_Click(object sender, EventArgs e) => Close();
    }
}
