namespace LerningWithWarzone.source.models
{
    public class Secondaryweapon
    {
        public string name { get; set; }
        public object label { get; set; }
        public object imageLoot { get; set; }
        public object imageIcon { get; set; }
        public string variant { get; set; }
        public Attachment1[] attachments { get; set; }
    }
}