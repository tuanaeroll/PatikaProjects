namespace Week5Final
{
    public class Car
    {
        public DateTime ProductionDate { get;private set; }
        public int SerialNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }

        public Car() 
        {
            ProductionDate = DateTime.Now;
        }
    }
}
