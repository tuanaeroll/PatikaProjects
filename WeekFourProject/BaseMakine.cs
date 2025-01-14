namespace WeekFourProject
{
    public abstract class BaseMakine
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }
        public DateTime UretimTarihi { get; set; }
        public int SeriNumarasi { get; set; }
        public BaseMakine(string ad, string aciklama, string isletimSistemi, int seriNumarasi)
        {
            Ad = ad;
            Aciklama = aciklama;
            IsletimSistemi = isletimSistemi;
            SeriNumarasi = seriNumarasi;
            UretimTarihi = DateTime.Now;
        }
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi.ToShortDateString()}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
        }
        public abstract void UrunAdiGetir();

    }
}
