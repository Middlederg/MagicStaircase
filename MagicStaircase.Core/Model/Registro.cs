using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagicStaircase.Core.Model
{
    public class Registro
    {
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public int Puntuacion { get; set; }
        public int SegundosUtilizados { get; set; }
        public bool Sistema { get; set; }

        public string Tiempo
        {
            get
            {
                int mins = (int)new TimeSpan(0, 0, SegundosUtilizados).TotalMinutes;
                int segs = SegundosUtilizados - mins * 60;
                return $"{(mins < 10 ? $"0{mins}" : mins.ToString())}:{(segs < 10 ? $"0{segs}" : segs.ToString())}";
            }
        }

        public ListViewItem Item(int? position)
        { 
            ListViewItem item = new ListViewItem(position.HasValue ? position?.ToString() + "." : "");
            item.SubItems.Add(Nombre);
            item.SubItems.Add(Puntuacion.ToString());
            item.SubItems.Add(Fecha.ToShortDateString());
            item.SubItems.Add(Tiempo);
            if (Sistema) item.ForeColor = Color.DarkGreen;
            return item;
        }
    }
}
