namespace Lists3
{
    public class Film
    {
        string Isim { get; set; }
        double ImdbPuani { get; set; }

        public Film(string isim, double imdbPuani)
        {
            Isim = isim;
            ImdbPuani = imdbPuani;
        }

        private static List<Film> filmler = new List<Film>();

        public static void Olustur()
        {
            while (true)
            {
                Console.WriteLine("Bir film ismi giriniz");
                string isim = Console.ReadLine();

                Console.WriteLine("IMDB puanını giriniz");
                double imdbPuani = Convert.ToDouble(Console.ReadLine());

                Film film = new Film(isim, imdbPuani);
                filmler.Add(film);

                Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
                string cevap = Console.ReadLine();

                if (cevap.ToUpper() == "H")
                {
                    break;
                }
            }
        }

        public static void Listele()
        {
            foreach (var film in filmler)
            {
                Console.WriteLine($"Film ismi: {film.Isim}, IMDB puanı: {film.ImdbPuani}");
            }
        }

        public static void FilmleriFiltrele() 
        {
            Console.WriteLine("IMDB puanı 4 ile 9 arasında olan filmler:");
            foreach (var film in filmler)
            {
                if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
                {
                    Console.WriteLine($"Film ismi: {film.Isim}, IMDB puanı: {film.ImdbPuani}");
                }
            }
        }

        public static void IsmiAileBaslayanlariListele()
        {
            Console.WriteLine("İsmi 'A' harfi ile başlayan filmler:");
            foreach (var film in filmler)
            {
                if (film.Isim.ToLower().StartsWith("a"))
                {
                    Console.WriteLine($"Film ismi: {film.Isim}, IMDB puanı: {film.ImdbPuani}");
                }
            }
        }
    }
}
