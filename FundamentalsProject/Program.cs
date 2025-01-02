// Main program loop
bool goOn = true;
while (goOn)
{
    // Ask user to select a program to run
    Console.WriteLine("Program havuzuna hoşgeldiniz! Burda neler yapabilirsiniz?\n1)Rastgele Sayı Bulma Oyunu\n2)Hesap Makinesi\n3)Ortalama Hesaplama\nÇalıştırmak istediğiniz programın numarasını giriniz (1-2-3):");
    // Get the program number from user
    int programNumber = Convert.ToInt32(Console.ReadLine());
        // Run the selected program
        switch (programNumber)
        {
            case 1:
                GuessTheRandomNumberGame();                break;
            case 2:
                Calculator();
                break;
            case 3:
                CalculateAverage();
                break;
            default:
                Console.WriteLine("Geçersiz program numarası girdiniz.");
                break;
        }
    // Ask if the user wants to continue
    Console.WriteLine("\nBaşka bir program çalıştırmak isterseniz devam etmek için herhangi bir harf yazın, çıkmak istiyorsanız çıkış yazınız:");
    string cevap = Console.ReadLine().ToLower();
        if (cevap == "çıkış")
        {
            goOn = false;
            Console.WriteLine("Programdan çıkılıyor...");
        }
        else
        {
            Console.Clear();
        }
}

void GuessTheRandomNumberGame()
{
    // Give information to user about the game
    Console.WriteLine("Rastgele Sayı Tahmin Oyunu'na hoş geldiniz! Sayıyı tahmin etmeye çalışın, ipuçlarını kullanın, ama unutmayın 5 canınız var.");
    // Generate a random number between 1 and 100
    Random random = new Random();
    int randomNumber = random.Next(1, 101);
    // Declare a variable to store the user's guess
    int guess = 0;
    // Set the health point to 5
    int health = 5;
    // Check if the guess is correct
    while (health > 0 && guess != randomNumber)
    {
        // Ask for a guess
        Console.WriteLine("Tahmininizi giriniz:");
        guess = Convert.ToInt32(Console.ReadLine());
        // Give hints based on the guess and reduce health points
        if (guess > randomNumber)
        {
            Console.WriteLine("Daha küçük bir tahmin yapınız");
            health--;
            Console.WriteLine($"Kalan canınız: {health}");
        }
        else if (guess < randomNumber)
        {
            Console.WriteLine("Daha büyük bir tahmin yapınız");
            health--;
            Console.WriteLine($"Kalan canınız: {health}");
        }
        // If the guess is correct, congratulate the user and end the game
        else
        {
            Console.WriteLine($"Tebrikler! Sayıyı doğru tahmin ettiniz.Doğru sayı -> {randomNumber}");
            break;
        }
        // Check if the user has any health points left
        if (health == 0)
        {
            Console.WriteLine($"Üzgünüm, can hakkınız bitti. Doğru sayı -> {randomNumber}");
            break;
        }
    }
}

void Calculator()
{
    // Give information to user about the calculator
    Console.WriteLine("Hesap makinesine hoşgeldiniz!Hesaplamak istediğiniz sayıları ve işlemi girerek sonucu elde edebilirsiniz.\nİlk sayıyı giriniz:");
    // Get the first number from user
    int number1 = Convert.ToInt32(Console.ReadLine());
    // Get the second number from user
    Console.WriteLine("İkinci sayıyı giriniz:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    // Get the operation symbol from user
    Console.WriteLine("İşlem sembolünü girin:\n1) Toplama (+)\n2) Çıkarma (-)\n3) Çarpma (*)\n4) Bölme (/)");
    char operation = Convert.ToChar(Console.ReadLine());
    // Declare a variable to store the result
    double result = 0;
    // Validate the operation
    if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
    {
        Console.WriteLine("Geçersiz işlem girdiniz.");
        return;
    }
    // Check the operation and calculate the result
    switch (operation)
    {
        case '+':
            result = number1 + number2;
            Console.WriteLine($"Sonuç -> {result}");
            break;
        case '-':
            result = number1 - number2;
            Console.WriteLine($"Sonuç -> {result}");
            break;
        case '*':
            result = number1 * number2;
            Console.WriteLine($"Sonuç -> {result}");
            break;
        case '/':
            if (number2 == 0)
            {
                Console.WriteLine("Bir sayıyı 0'a bölemezsiniz.");
                break;
            }
            else
            {
                result = (double)number1 / number2;
                Console.WriteLine($"Sonuç -> {result}");
            }
            break;
        default:
            Console.WriteLine("Geçersiz işlem girdiniz.");
            break;
    }
}

void CalculateAverage()
{
    // Give information to user about the average calculation
    Console.WriteLine("Ortalama Hesaplama'ya hoş geldiniz! Birkaç not girip ortalamanızı hesaplayabilirsiniz.");
    // Declare an array to store the grades
    int[] grades = new int[3];
    // Declare a variable to store the total
    double total = 0;
    // Get the grades from user
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"{i + 1}. notu girin:");
        grades[i] = Convert.ToInt32(Console.ReadLine());
        // Check if the grades are within a valid range (0-100)
        if (grades[i] < 0 || grades[i] > 100)
        {
            Console.WriteLine("Geçersiz not girdiniz.");
            return;
        }
        total += grades[i];
    }
    // Calculate the average
    double average = total / grades.Length;
    // Round the average to 2 decimal places
    average = Math.Round(average, 2);
    // Declare a variable to store the letter grade
    string letterGrade = average >= 90 ? "AA" :
                         average >= 85 ? "BA" :
                         average >= 80 ? "BB" :
                         average >= 75 ? "CB" :
                         average >= 70 ? "CC" :
                         average >= 65 ? "DC" :
                         average >= 60 ? "DD" :
                         average >= 55 ? "FD" : "FF";
    // Print the average and letter grade
    Console.WriteLine($"Ortalamanız -> {average} - {letterGrade}");
}
