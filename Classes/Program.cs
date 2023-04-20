namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = " Honda";
            myCar.Model = "Accord";
            myCar.Year = "2050";

            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);


            Car yourCar = new Car() { Make = " Bugatti", Model = "Unknown", Year = "2030" };

            Console.WriteLine();
            Console.WriteLine($"My {yourCar.Make} is better or better looking than your {myCar.Make}");
            
            

               
                
                
        }
    }
}
