namespace ConsoleApp1.source.models
{
    public class Loadout
    {
        public Primaryweapon primaryWeapon { get; set; }
        public Secondaryweapon secondaryWeapon { get; set; }
        public Perk[] perks { get; set; }
        public Extraperk[] extraPerks { get; set; }
        public Killstreak[] killstreaks { get; set; }
        public Tactical tactical { get; set; }
        public Lethal lethal { get; set; }
    }
}