namespace OOP_Review.InheritanceModels
{
    internal class Sarkici : BaseKatilimci
    {
        public string SonAlbum { get; set; }

        public void SarkiSoyle()
        {
            Console.WriteLine("Lay la lay ...");
        }
    }
}
