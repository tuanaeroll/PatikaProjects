namespace WeekFourProject
{
    public class Telefon : BaseMakine
    {
        public bool TrLisansli { get; set; }
        public Telefon(string ad, string aciklama, string isletimSistemi, int seriNumarasi, bool trLisansli) : base (ad, aciklama, isletimSistemi, seriNumarasi)
        {
            TrLisansli = trLisansli;
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Türk Lisanslı mı? {(TrLisansli ? "Evet" : "Hayır")}");
        }
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı -> {Ad}");
        }
    }
}
