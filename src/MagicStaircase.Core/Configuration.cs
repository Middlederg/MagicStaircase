using System.Reflection;

namespace MagicStaircase.Core.Model
{
    public static class Configuration
    {
        public const string LatestRelease = "https://api.github.com/repos/Middlederg/MagicStaircase/releases/latest";
        //public const string adasd;

        public static string CurrentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return $"v{assembly.GetName().Version.ToString()}";
        }
    }
}
