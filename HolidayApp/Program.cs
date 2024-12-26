// Kullanıcıya hoşgeldin de ve lokasyon sor.
do
{
    Console.WriteLine("Tatil Uygulamasına hoşgeldiniz! Lütfen nereye gitmek istediğinizi seçiniz: -Bodrum, - Marmaris, - Çeşme");
    string location = Console.ReadLine().ToLower();

    // Kullanıcı geçerli bir lokasyon girene kadar döngü devam eder.
    while (location != "bodrum" && location != "marmaris" && location != "çeşme")
    {
        Console.WriteLine("Geçersiz bir lokasyon girdiniz! Lütfen tekrar deneyiniz.");
        location = Console.ReadLine().ToLower();
    }

    // Kullanıcıya kaç kişi olduğunu sor.
    Console.WriteLine("Kaç kişisiniz?");
    int numberOfPeople = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    // Kullanıcının girdiği lokasyona göre ekrana mesaj yazdırılır.
    switch (location)
    {
        case "bodrum":
        Console.WriteLine("Bodrum'a hoşgeldiniz! Burada neler yapabilirsiniz: - Deniz, - Güneş, - Eğlence");
        sum += 4000 * numberOfPeople;
            break;
        case "marmaris":
        Console.WriteLine("Marmaris'e hoşgeldiniz! Burada neler yapabilirsiniz: - Deniz, - Güneş, - Eğlence");
        sum += 3000 * numberOfPeople;
            break;
        case "çeşme":
        Console.WriteLine("Çeşme'ye hoşgeldiniz! Burada neler yapabilirsiniz: - Deniz, - Güneş, - Eğlence");
        sum += 5000 * numberOfPeople;
            break;
    }

    // Hangi yolu tercih etmek istediğini sor.
    // Kullanıcı geçerli bir ulaşım yolu girene kadar döngü devam eder.
    while (true)
    {
        Console.WriteLine("Hangi ulaşım yolunu tercih etmek istersiniz? -Kara yolu için 1, -Hava yolu için 2 yazınız.");
        string transportation = Console.ReadLine();

        // Kullanıcının seçtiği ulaşım yolu toplam değere eklenir.
        switch (transportation)
        {
            case "1":
                sum += 1500 * numberOfPeople;
                break;
            case "2":
                sum += 4000 * numberOfPeople;
                break;
            default:
                Console.WriteLine("Geçersiz bir ulaşım yolu girdiniz!");
                continue;
        }
        break;
    }
    // Toplam tutarı ekrana yazdır.
    Console.WriteLine($"Bu muhteşem tatil için harcayacağınız tutar -> {sum}\nBaşka bir tatil planlamak ister misiniz? (evet/hayır)");
} while (Console.ReadLine().ToLower() == "evet");

Console.WriteLine("Bizi seçtiğiniz için teşekkürler. İyi günler!");