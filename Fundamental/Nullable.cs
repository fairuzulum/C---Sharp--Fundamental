namespace Fundamental;

public class Nullable
{
    public static void NullableMain()
    {
        // int number = null; // error
        
        // menggunakan tipe data generic
        Nullable<int> number = null;
        
        // menggunakan operator optional
        int? number2 = null;
        
        Console.WriteLine(number2); // akan ditampilkan kosong
        // C# sudah null safety

        if (number2.HasValue)
        {
            Console.WriteLine(number2.Value);
        }
        else
        {
            Console.WriteLine("Data is Empty");
        }
    }
}