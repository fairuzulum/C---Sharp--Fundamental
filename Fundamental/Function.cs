namespace Fundamental;

public class Function
{
    
    // Cara akses method static
    public static void FunctionMain()
    {
        MyName("Fairuz");
        MyAge(20);
    }
    
    /*
     * ACCESS MODIFIER (static/non static)
     *
     * method static hanya bisa diakses oleh method static juga
     *
     * static (terikat oleh kelas itu sendiri)
     * non-static (tidak terikat, harus dibuat object terlebih dahulu)
     */
    
    
    // method static
    public static void MyName(string name)
    {
        Console.WriteLine($"Hello {name}");
    }
    
    // method non-static
    public static void MyAge(int age)
    {
        Console.WriteLine($"Age : {age}");
    }

}

