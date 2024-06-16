namespace Fundamental;

public class Looping
{
    public static void LoopingMain()
    {
        /*
         * Looping
         *
         * 1. for
         * 2. while
         * 3. do-while
         */
        
        // for loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"My Name Fairuz - Perulanga ke ({i}) ");
        }
        
        // while loop
        int a = 1;
        while (a < 10)
        {
            Console.WriteLine($"Perulangan ke - {a}");
            a++;
        }
        
        // do-while loop

        int b = 20;
        do
        {
            Console.WriteLine("Ini Do while");
        } while (b > 21);

    }
}