// Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

// ( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

        // WHILE

        int sayac = 1;
        int limit;
        Console.WriteLine("Lütfen bir sayı girin");
        limit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("While döngüsü başladı:");
        while (sayac <= limit)
        {
            Console.WriteLine($"{sayac}-> Ben bir Patika'lıyım");
            sayac++;
        }

        // DO-WHILE
        Console.WriteLine("Do-While döngüsü başladı:");
        sayac = 1;
        do
        {
            Console.WriteLine($"{sayac}-> Ben bir Patika'lıyım");
            sayac++;
        } while (sayac <= limit);

        // While önce koşulu kontrol eder, koşul sağlanmıyorsa döngü bir kez bile çalışmaz. Do-While'da ise döngü bir kez çalışır, koşul ardından kontrol edilir. Kullanıcıdan veri alırken en az bir kez döngünün çalışması gereken hallerde Do-While'ı kullanmak gerekir. Örneğin bu pratikte kullanıcı inputu 0 olursa while döngüsü ekrana bir çıktı vermeyecektir ama do-while döngüsü bir tur döngüyü çalıştıracaktır.
        