using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

namespace MagicStaircase.Data
{
    public static class GameHelper
    {
        public static string ReplaceConnectionString()
        {
#if DEBUG
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MagicStaircase";
            string path = Environment.CurrentDirectory;
            Debug.WriteLine("Cadena conexion: " + path);
#else
            string path = Environment.CurrentDirectory;
#endif

            return $"metadata=res://*/GameModel.csdl|res://*/GameModel.ssdl|res://*/GameModel.msl;provider=System.Data.SqlClient;provider connection string=\"data source=(LocalDB)\\MSSQLLocalDB;attachdbfilename={path}\\GameDB.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\"";
        }
    }
}
