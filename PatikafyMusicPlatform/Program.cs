using PatikafyMusicPlatform;

List<Sanatci> sanatcilar = new List<Sanatci>
{
    new Sanatci { Ad = "Ajda Pekkan", Tur = "Pop", Yil = 1968, Satis =  20000000 },
    new Sanatci { Ad = "Sezen Aksu", Tur = "Türk Halk Müziği / Pop", Yil = 1971, Satis = 10000000 },
    new Sanatci { Ad = "Funda Arar", Tur = "Pop", Yil = 1999, Satis = 3000000 },
    new Sanatci { Ad = "Sertab Erener", Tur = "Pop", Yil = 1994, Satis = 5000000 },
    new Sanatci { Ad = "Sıla", Tur = "Pop", Yil = 2009, Satis = 3000000 },
    new Sanatci { Ad = "Serdar Ortaç", Tur = "Pop", Yil = 1994, Satis = 10000000 },
    new Sanatci { Ad = "Tarkan", Tur = "Pop", Yil = 1992, Satis = 40000000 },
    new Sanatci { Ad = "Hande Yener", Tur = "Pop", Yil = 1999, Satis = 7000000 },
    new Sanatci { Ad = "Hadise", Tur = "Pop", Yil = 2005, Satis = 5000000 },
    new Sanatci { Ad = "Gülben Ergen", Tur = "Pop / Türk Halk Müziği", Yil = 1997, Satis = 10000000 },
    new Sanatci { Ad = "Neşet Ertaş", Tur = "Türk Halk Müziği / Türk Sanat Müziği", Yil = 1960, Satis = 2000000 }
};
Console.WriteLine("Şarkıcı Listesi:\n");
foreach (var sanatci in sanatcilar) { Console.WriteLine(sanatci); }

Console.WriteLine("\nAdı 'S' ile başlayan şarkıcılar:\n");
var adBazli = sanatcilar.Where(s => s.Ad.StartsWith("S"));
foreach (var sanatci in adBazli) { Console.WriteLine(sanatci); }

Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar:\n");
var satisBazli = sanatcilar.Where(s => s.Satis > 10000000);
foreach (var sanatci in satisBazli) { Console.WriteLine(sanatci); }

Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:\n");
var grupBazli = sanatcilar.Where(s => s.Yil < 2000 && s.Tur == "Pop")
    .OrderBy(s => s.Ad)
    .GroupBy(s => s.Yil);
foreach (var grup in grupBazli)
{
    foreach (var sanatci in grup)
    {
        Console.WriteLine(sanatci);
    }
}

Console.WriteLine("\nEn çok albüm satan şarkıcı:\n");
var albumBazli = sanatcilar.OrderByDescending(s => s.Satis).First();
Console.WriteLine(albumBazli);

Console.WriteLine("\nEn eski ve en yeni çıkış yapan şarkıcılar:\n");
var cikisBazliEski = sanatcilar.OrderBy(s => s.Yil).First();
Console.WriteLine("En eski çıkış yapan sanatçı -> " + cikisBazliEski);
var cikisBazliYeni = sanatcilar.OrderByDescending(s => s.Yil).First();
Console.WriteLine("En yeni çıkış yapan sanatçı -> " + cikisBazliYeni);