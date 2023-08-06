using System;

namespace DaireYonetim.Entity
{
    public class Mesaj : BaseEntity
    {
        public int KullanıcıID { get; set; }
        public string Metin { get; set; }
        public DateTime Tarih { get; set; }
        public bool Okundumu { get; set; }
    }
}
