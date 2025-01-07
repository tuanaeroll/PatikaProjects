using PatikaKütüphanesi;

// New: Kitap sınıfından bir nesne oluşturmak için kullanılır. Nesne oluşturulduğunda, constructor (yapıcı metot) otomatik olarak çalışır.
Kitap kitap1 = new Kitap("1984", "George Orwell", "Can Yayınları", 352);
Kitap kitap2 = new Kitap("Sineklerin Tanrısı", "William Golding", "İthaki Yayınları", 408);

// Parametresiz constructor kullanılarak oluşturulan nesnelere özellikler sonradan atanır.
Kitap kitap3 = new Kitap();
kitap3.Ad = "Hayvan Çiftliği";
kitap3.YazarAdi = "George Orwell";
kitap3.YayinEvi = "Can Yayınları";
kitap3.SayfaSayisi = 152;
kitap3.Olustur();

Kitap kitap4 = new Kitap();
kitap4.Ad = "Körlük";
kitap4.YazarAdi = "Jose Saramago";
kitap4.YayinEvi = "Kırmızı Kedi Yayınları";
kitap4.SayfaSayisi = 312;
kitap4.Olustur();

