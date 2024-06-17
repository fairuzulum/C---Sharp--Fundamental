namespace Fundamental;

public class OperatorAritmatik
{
    public static void OperatorMain()
    {
        /*
         * Operator Aritmatik
         *
         * (+) Penjumlahan
         * (-) Pengurangan
         * (*) Perkalian
         * (/) Pembagian
         * (%) Modulus
         * (++) Increment
         * (--) Decrement
         */

        int a = 10;
        int b = 2;
        
        
        // Penjumlahan
        Console.WriteLine(a + b);
        
        // Pengurangan
        Console.WriteLine(a - b);
        
        // Perkalian
        Console.WriteLine(a * b);
        
        // Pembagian 
        Console.WriteLine(a / b);
        
        // Modulus
        Console.WriteLine(a % b);
        
        /*
         * INCREMENT & DECREMENT
         * Post (variable di cetak dulu baru ditambah)
         * Pre (Variable di tambah dulu baru di cetak)
         */
        
        int x = 5;
        int y = 5;
        
        // Post-Increment
        Console.WriteLine(x++);
        
        // Pre-Increment
        Console.WriteLine(++y);
        
        // Post-Decrement
        Console.WriteLine(a--);
        
        // Pre-Decrement
        Console.WriteLine(--b);
        
    }
}