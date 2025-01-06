using Constructor1;

Bebek bebek1 = new Bebek();
bebek1.Ad = "Chandler";
bebek1.Soyad = "Bing";
Console.WriteLine($"{bebek1.Ad} {bebek1.Soyad}");
bebek1.Dogum();

Bebek bebek2 = new Bebek("Monica", "Geller");
Console.WriteLine($"{bebek2.Ad} {bebek2.Soyad}");
bebek2.Dogum();

