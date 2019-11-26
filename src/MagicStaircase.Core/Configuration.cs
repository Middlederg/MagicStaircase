using System.IO;
using System.Reflection;

namespace MagicStaircase.Core
{
    public static class Configuration
    {
        public static string MainDirectory = Directory.GetCurrentDirectory();
        public static string ScoresDirectory = $@"{MainDirectory}\scores\";
        public static string ScoresFile = $@"{ScoresDirectory}data.txt";

        public const string RepoOwner = "Middlederg";
        public const string RepoName = "MagicStaircase";
        public static string RepoLink = $"https://github.com/{RepoOwner}/{RepoName}";
        public static string LatestRelease = $"https://api.github.com/repos/{RepoOwner}/{RepoName}/releases/latest";

        public static string CurrentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return $"v{assembly.GetName().Version.ToString(3)}";
        }
    }
}
