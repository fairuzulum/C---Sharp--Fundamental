namespace Fundamental;

public class Array
{
    public static void ArrayMain()
    {
        // Deklarasi array Explisit 01
        int[] arr = new int[3];
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        
        // Deklarasi array Explisit 02
        int[] arr2 = { 1, 2, 3 };
        
        // Akses Array
        Console.WriteLine(arr2[0]);
        
        // Deklarasi array Implisit 01
        var cities = new string[3];
        cities[0] = "Bekasi";
        cities[1] = "Jakarta";
        cities[2] = "Bandung";
        
        // Deklarasi array implisit 02
        var animals = new[] {"Cat", "Tiger", "Crab"};
        
        // Array 2 dimensi
        int[,] score = {{1,2},{2,3},{4,5}};
        
        // looping Array (for)
        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine($"Citiy : {cities[i]}");
        }
        
        // looping array (foreach)
        foreach (var city in cities)
        {
            Console.WriteLine($"City : {city}");
        }
        
        // Akses array 2 dimensi with looping
        for (int x = 0; x < score.GetLength(0); x++)
        {
            for (int y = 0; y < score.GetLength(1); y++)
            {
                Console.WriteLine($"Akses data : {score[x,y]} Index Ke - {x}");
            }
        }
    }
}