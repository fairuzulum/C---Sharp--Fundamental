namespace Fundamental;

public class AnonymousFunction
{
    public static void AnonymousFunctionMain()
    {
       
        // cara 1 => menggunakan delegate
        var print = delegate(int a, int b)
        {
            Console.WriteLine(a + b);
        };
        
        // cara 2 => Menggunakan lambda
        var multiply = (int x, int y) =>
        {
            Console.WriteLine(x * y);
        };

        print(2, 3);
        multiply(5, 3);
    }
}