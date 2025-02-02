namespace PatikafyMusicPlatform
{
    internal class Sanatci
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Yil { get; set; }
        public int Satis { get; set; }

        public override string ToString()
        {
            return $"{Ad} - {Tur} - {Yil} - {Satis}";
        }
    }
}
