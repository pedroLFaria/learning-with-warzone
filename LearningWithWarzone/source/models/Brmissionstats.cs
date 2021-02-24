namespace LerningWithWarzone.source.models
{
    public class Brmissionstats
    {
        public int missionsComplete { get; set; }
        public float totalMissionXpEarned { get; set; }
        public float totalMissionWeaponXpEarned { get; set; }
        public Missionstatsbytype missionStatsByType { get; set; }
    }
}