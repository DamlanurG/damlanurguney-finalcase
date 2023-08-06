namespace DaireYonetim.Entity
{
    public class Fatura : BaseEntity
    {
        public int DaireID { get; set; }
        public int Ay { get; set; }
        public int Tutar { get; set; }
        public bool Odendimi { get; set; }
    }
}
