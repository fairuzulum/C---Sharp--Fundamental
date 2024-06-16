using System.Diagnostics;

namespace Fundamental;

public class Condition
{
    public static void ConditionMain()
    {
        
        /*
         * Conditional
         * 1. if - else if
         * 2. Switch Case
         */
        int a = 10;
        int b = 20;
        if (a > b)
        {
            Console.WriteLine("Malam");
        }
        else if (a < b)
        {
            Console.WriteLine("Pagi");
        }
        else
        {
            Console.WriteLine("hmmmm");
        }


        var day = 'S';
        
        switch(day)
        {
            case 'S':
                Console.WriteLine("Sunday");
                break;
            case 'M':
                Console.WriteLine("Monday");
                break;
            default:
                Console.WriteLine("Is Not Day");
                break;
        }





    }
}