namespace DaireYonetim.Entity
{
    public class Kullanici : BaseEntity
    {
        public string AdSoyad { get; set; }
        public string TCNo { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string AracPlaka { get; set; }
        public string Sifre { get; set; }
        public int DaireID { get; set; }
    }
}
