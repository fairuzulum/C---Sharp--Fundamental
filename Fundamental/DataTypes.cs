namespace Fundamental;

public class DataTypes
{
    public static void DataTypesMain()
    {
        // Data Types 
        
        /*
         * Number
         *
         * 1- byte
         * 2- short
         * 3- int
         * 4- long
         */
        
        // byte
        byte typeByte = 1;
        Console.WriteLine(typeByte);
        
        // short 
        short typeShort = 1;
        Console.WriteLine(typeShort);
        
        // int 
        int typeInt = 3213;
        Console.WriteLine(typeInt);
        
        // long 
        long typeLong = 3243242432L;
        Console.WriteLine(typeLong);
        
        // Unsigned Type (short,int,long) => tidak boleh bilangan negatif
        ushort typeUshort = 1; // -1 (error)
        uint typeUint = 2;
        ulong typeUlong = 123123243243L;
        
        
        /*
         * Floating Point
         *
         * 1- float
         * 2- double
         * 3- decimal
         */
        
        // float
        float typeFloat = 3.14F;
        // double
        double typeDouble = 3424.434D;
        // decimal
        decimal typeDecimal = 247832.4327264M;
        
        Console.WriteLine(typeFloat);
        Console.WriteLine(typeDouble);
        Console.WriteLine(typeDecimal);
        
        
        



    }
}