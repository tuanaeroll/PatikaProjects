using Week5Final;

List<Car> cars = new List<Car>();

while (true)
{
    Console.WriteLine("Do you want to create a car?(Y/N)");

    string answer = Console.ReadLine().ToLower();

    if (answer == "n")
    {
        if (cars.Count > 0)
        {
            Console.WriteLine("\nCreated cars:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Serial Number: {car.SerialNumber}, Brand: {car.Brand}, Production Time: {car.ProductionDate}");
            }
        }
        else
        {
            Console.WriteLine("No cars were created.");
        }

        Console.WriteLine("Goodbye..");
        break;
    }
    else if (answer == "y") 
    {
        Car car = new Car();

    RetrySerialNumber:
        Console.Write("SerialNumber: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int serialNumber))
        {
            car.SerialNumber = serialNumber;
        }
        else
        {
            Console.WriteLine("Please give a valid serial number.(23456789)");
            goto RetrySerialNumber;
        }

        Console.Write("Brand: ");
        car.Brand = Console.ReadLine();

        Console.Write("Model: ");
        car.Model = Console.ReadLine();

        Console.Write("Color: ");
        car.Color = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("Number Of Doors: ");
            string doors = Console.ReadLine();

            if (int.TryParse(doors, out int numberOfDoors))
            {
                car.NumberOfDoors = numberOfDoors;
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
        cars.Add(car);
    }
    else
    {
        Console.WriteLine("Answer is not valid. Please enter Y or N.");
    }
}

