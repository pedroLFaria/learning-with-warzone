namespace LerningWithWarzone.source.models
{
    public class Player
    {
        public string team { get; set; }
        public float rank { get; set; }
        public Awards awards { get; set; }
        public string username { get; set; }
        public string uno { get; set; }
        public string clantag { get; set; }
        public Brmissionstats brMissionStats { get; set; }
        public Loadout[] loadout { get; set; }
        public int kills { get; set; }
        public int death { get; set; }
        public int damageDone { get; set; }
        public int damageTaken { get; set; }
    }
}