namespace Fundamental;

public class Car
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public int Fuel { get; set; }
    
   
}

public class Program
{
    public static void ProgramMain()
    {
        
        // Instance Object
        Car ayla = new Car
        {
            Color = "Blue",
            Brand = "Totoya",
            Fuel = 40
        };
        
        Console.WriteLine(ayla.Color);
        Console.WriteLine(ayla.Brand);
        Console.WriteLine(ayla.Fuel);


    }
}