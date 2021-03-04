namespace MagicStaircase.Web
{
    public static class Colors
    {
        public static string GetColor(this Core.Achievement achievement, string defaultColor = "white")
        {
            if (achievement != null && achievement.IsGold()) return "yellow-300";
            if (achievement != null && achievement.IsSilver()) return "gray-200";
            if (achievement != null && achievement.IsBronze()) return "yellow-500";
            return defaultColor;
        }
    }
}
