namespace OOP_Review.InheritanceModels
{
    internal class BaseKatilimci
    {
        public string Ad {  get; set; }
        public string Soyad { get; set; }

        // Virtual keyword ü ile metodu esnek , Override edilebilir hale getiririz.
        // Böylece bu metodun çalışma şeklini miras alınan class ta override edebiliriz..
        public virtual void RoportajVer()
        {
            Console.WriteLine("Çok güzel bir ekiple çalıştık.");
        }

    }
}
