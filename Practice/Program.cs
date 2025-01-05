//// 1. Metot ile Karşılama Mesajı Yazdırma
//// Bir metot tanımlayın. Bu metot bir ismi parametre olarak alıp ekrana şu şekilde yazsın:
//// Merhaba [isim]! Hoş geldiniz.

//string name;
//void Greeting()
//{
//    Console.WriteLine("Lütfen isminizi giriniz:");
//    name = Console.ReadLine();
//    Console.WriteLine($"Merhaba {name}! Hoş geldiniz.");
//}

//Greeting();

//// 2. Metot ile Çift Sayıları Toplama
//// Bir metot tanımlayın. Bu metot bir sayı dizisi alsın ve dizideki çift sayıların toplamını döndürsün.

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int SumOfEvenNumbers(int[] numbers)
//{
//    int sum = 0;
//    foreach (var number in numbers)
//    {
//        if (number % 2 == 0)
//        {
//            sum += number;
//        }
//    }
//    return sum;
//}

//SumOfEvenNumbers(numbers);

//// 3. 1'den N'e Kadar Sayıları Listeleme
//// Bir metot yazın. Bu metot parametre olarak bir sayı alıp, 1'den o sayıya kadar olan tüm sayıları listeleyip ekrana yazdırsın.

//void ListNumbers(int number)
//{
//    for (int i = 1; i <= number; i++)
//    {
//        Console.WriteLine($"{i}");
//    }
//}

//ListNumbers(10);

//// 4. Faktöriyel Hesaplama
//// Bir metot tanımlayın. Bu metot bir sayı alıp bu sayının faktöriyelini hesaplasın ve döndürsün.
//// (Örn: 5! = 5 x 4 x 3 x 2 x 1 = 120)

//int Factorial(int number)
//{
//    int result = 1;
//    for (int i = 1; i <= number; i++)
//    {
//        result *= i;
//    }
//    return result;
//}

//Console.WriteLine( Factorial(5));

//// 5. Tek mi Çift mi?
//// Bir metot tanımlayın. Bu metot bir sayı alıp o sayının tek mi çift mi olduğunu kontrol edip true ya da false döndürsün.
//bool IsEven(int number)
//{
//    return number % 2 == 0;
//}

//Console.WriteLine(IsEven(5));

//// 6. "FizzBuzz" Oyunu
//// Bir metot yazın. Bu metot 1’den 100’e kadar sayıları ekrana yazsın. Ancak:
//// - Sayı 3’e bölünüyorsa "Fizz",
//// - Sayı 5’e bölünüyorsa "Buzz",
//// - Hem 3’e hem 5’e bölünüyorsa "FizzBuzz" yazdırılsın.

//void FizzBuzz(int input)
//{
//    for (int i = 1; i <= 100; i++)
//    {
//        if (i % 3 == 0 && i % 5 == 0)
//        {
//            Console.WriteLine("FizzBuzz");
//        }
//        else if (i % 3 == 0)
//        {
//            Console.WriteLine("Fizz");
//        }
//        else if (i % 5 == 0)
//        {
//            Console.WriteLine("Buzz");
//        }
//        else
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

//FizzBuzz(10);

//// 7. Bir Dizi Elemanlarının Kaç Kere Geçtiğini Sayma
//// Bir metot yazın. Bu metot bir dizi alsın ve her elemanın kaç kere geçtiğini ekrana yazsın.
//// (Örn: Dizi [1, 2, 2, 3, 3, 3] ise çıktı: 1: 1 kez, 2: 2 kez, 3: 3 kez)

//// 8. Taban ve Üs Hesaplama
//// Bir metot yazın. Bu metot bir taban ve üs değeri alarak şu formülü hesaplasın:
//// Taban^Üs (Örn: 2^3 = 2 x 2 x 2 = 8)

//// 9. Asal Sayı Kontrolü
//// Bir metot yazın. Bu metot bir sayı alıp bu sayının asal olup olmadığını kontrol etsin ve sonucu döndürsün.
//// (Asal sayılar: Kendisi ve 1 dışında böleni olmayan sayılar, örn: 2, 3, 5, 7, 11)

//// 10. Fibonacci Dizisi
//// Bir metot yazın. Bu metot bir sayı alıp, o sayıya kadar olan Fibonacci dizisini ekrana yazsın.
//// (Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13... her sayı kendinden önceki iki sayının toplamıdır)