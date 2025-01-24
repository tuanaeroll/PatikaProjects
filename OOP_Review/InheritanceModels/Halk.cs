namespace OOP_Review.InheritanceModels
{
    internal class Halk : BaseKatilimci
    {
        // Diğer tüm katılımcılarda çalışan Base de tanımlanan RöportajVer() metodunun Halk classında da çalışmasını ama farklı çalışmasını istiyoruz.

        // POLYMORPHISM (Çok Biçimlilik) -> Virtual / Override

        public override void RoportajVer()
        {
            Console.WriteLine("Altın kelebek çok bozdu.");

            // Alttaki kodu tutarsak gidip base deki metodu çalıştırır. Bazen hem burda içeride değişiklik yapacağız hem de base metodunu kullanacağız.
            // base.RoportajVer();
        }
    }
}
