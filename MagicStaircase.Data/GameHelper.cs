using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MagicStaircase.Data
{
    public static class GameHelper
    {
        public static string ReplaceConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return $"metadata=res://*/GameModel.csdl|res://*/GameModel.ssdl|res://*/GameModel.msl;provider=System.Data.SqlClient;provider connection string=\"data source=(LocalDB)\\MSSQLLocalDB;attachdbfilename={path}\\MagicStaircase\\GameDB.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\"";
        }
    }
}
