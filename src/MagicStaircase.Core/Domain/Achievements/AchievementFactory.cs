using System.Collections.Generic;

namespace MagicStaircase.Core
{
    public static class AchievementFactory
    {
        public static IUnlockingStrategy PointsAtLeast(int points) => new MinimunScoreStrategy(points);
        public static IUnlockingStrategy UnderMinutes(int minutes) => new MinimunTimeStrategy(new Time(seconds: minutes * 60));

        public static IUnlockingStrategy AtLeast100Points => PointsAtLeast(100);
        public static IUnlockingStrategy AtLeast99Points => PointsAtLeast(99);
        public static IUnlockingStrategy AtLeast98Points => PointsAtLeast(98);
        public static IUnlockingStrategy AtLeast95Points => PointsAtLeast(95);
        public static IUnlockingStrategy AtLeast90Points => PointsAtLeast(90);
        public static IUnlockingStrategy AtLeast85Points => PointsAtLeast(85);

        public static Achievement GoldMedal => new Achievement("Gold medal", AtLeast100Points);
        public static Achievement SilverMedal => new Achievement("Silver medal", AtLeast99Points);
        public static Achievement BronzeMedal => new Achievement("Bronze medal", AtLeast98Points);
        public static Achievement MagicalCertificate => new Achievement("Magical certificate", AtLeast95Points);
        public static Achievement ExcelenceCertificate => new Achievement("Excelence certificate", AtLeast90Points);
        public static Achievement ApprovalCertificate => new Achievement("Approval certificate", AtLeast85Points);

        public static Achievement FastPlayer => new Achievement("Fast player", UnderMinutes(1));
        public static Achievement EasyAchievemnt => new Achievement("Easy one", PointsAtLeast(10));
        public static Achievement OnePointAchievemnt => new Achievement("One point", PointsAtLeast(1));
        public static Achievement TwoPointsAchievemnt => new Achievement("Two points", PointsAtLeast(2));

        public static List<Achievement> Achievements = new List<Achievement>
        {
            GoldMedal,
            SilverMedal,
            BronzeMedal,
            MagicalCertificate,
            ExcelenceCertificate,
            ApprovalCertificate,
            FastPlayer,
            EasyAchievemnt,
#if DEBUG 
            OnePointAchievemnt,
            TwoPointsAchievemnt
#endif
        };
    }
}
