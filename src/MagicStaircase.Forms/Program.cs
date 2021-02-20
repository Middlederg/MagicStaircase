using System;
using System.Windows.Forms;

namespace MagicStaircase.Forms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Core.Negocio.GameHelper.ReplaceConnectionString();
            //MessageBox.Show(ConfigurationManager.ConnectionStrings["GameDBEntities"].ConnectionString);

            Application.Run(new MainMenuView());
        }
    }
}
