namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Nissan";
            carOne.Model = "Altima";
            carOne.Year = 2019;
            
            Console.WriteLine($"This is a {carOne.Year} {carOne.Make} {carOne.Model}.");
        }
    }
}
