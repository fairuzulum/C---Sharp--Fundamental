namespace Fundamental;

public class Input
{
    public static void InputMain()
    {
        Console.Write("Masukan Nilai : ");
        var inputString = Console.ReadLine(); // data yang diterima selalu string
        Console.WriteLine(inputString.GetType());
        
        Console.Write("Masukan Angka : ");
        var input2 = Console.ReadLine(); // data yang diterima selalu int
        Console.WriteLine(input2.GetType());
        
        
        // Casting Type data
        
        // String to int
        int result = Convert.ToInt32(inputString);
        int result2 = Convert.ToInt32(input2);
            
        
        Console.WriteLine(result2 + result);
    }
}