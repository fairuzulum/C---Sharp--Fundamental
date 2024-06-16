namespace Fundamental;


enum Gender
{
    Male,
    Female
}

enum Role
{
    SuperAdmin = 100,
    Admin = 50,
    User = 10
}

public class EnumType
{

    public static void EnumTypeMain()
    {
        Console.WriteLine(Gender.Female);
        Console.WriteLine(Gender.Male.ToString()); // casting dari ENUM ke String

        int superAdmin = (int)Role.SuperAdmin;
        Console.WriteLine(superAdmin);
    }
    
}