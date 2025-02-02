List<int> numbers = new List<int> { 5, 10, 15, 20, -5, -10, -15, -20};

var evenNumbers = numbers.Where(x => x % 2 == 0);
foreach (var number in evenNumbers){ Console.WriteLine(number); }
Console.WriteLine("----------------------------");

var oddNumbers = numbers.Where(x => x % 2 != 0);
foreach (var number in oddNumbers){ Console.WriteLine(number); }
Console.WriteLine("----------------------------");

var negativeNumbers = numbers.Where(x => x < 0);
foreach (var number in negativeNumbers) { Console.WriteLine(number); }
Console.WriteLine("----------------------------");

var positiveNumbers = numbers.Where(x => x > 0);
foreach (var number in positiveNumbers) { Console.WriteLine(number); }
Console.WriteLine("----------------------------");

var specificNumbers = numbers.Where(x => x > 15 && x < 22);
foreach (var number in specificNumbers) { Console.WriteLine(number); }
Console.WriteLine("----------------------------");

var squaredNumbers = numbers.Select(x => x * x);
foreach (var number in squaredNumbers){ Console.WriteLine(number); }


