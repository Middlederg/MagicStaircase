using Squirrel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicStaircase.Forms
{
    static class Program
    {
        public const string UpdatePath = "https://github.com/Middlederg/MagicStaircase";

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

            try
            {
                //Releasify:  Squirrel --releasify Nuget/MagicStaircase.1.0.x.nupkg
                using (var mgr = UpdateManager.GitHubUpdateManager(UpdatePath))
                {
                    bool updated = false;
                    using (var updateManager = mgr.Result)
                    {
                        var updateInfo = updateManager.CheckForUpdate().Result;
                        if (updateInfo.ReleasesToApply.Any())
                        {
                            updateManager.UpdateApp();
                            updated = true;
                        }
                    }
                    if (updated)
                        UpdateManager.RestartApp();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo actualizar correctamente");
            }

            Application.Run(new FrmMenuPrincipal());
        }
    }
}
