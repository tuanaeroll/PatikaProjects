namespace PatikafySeriesPlatform
{
    public class Dizi
    {
        public string DiziAdi { get; set; }
        public string DiziTuru { get; set; }
        public string Yonetmen { get; set; }
        public int Yil { get; set; }

        public Dizi(string diziAdi, string diziTuru, string yonetmen, int yil)
        {
            DiziAdi = diziAdi;
            DiziTuru = diziTuru;
            Yonetmen = yonetmen;
            Yil = yil;
        }
    }
}
