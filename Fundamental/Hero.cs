namespace Fundamental;

public class Hero
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int BaseDamage { get; set; }

    public void Attack(Hero hero)
    {
        hero.GetHit(BaseDamage);
    }
    
    // Overloading
    public void Attack(Monster hero)
    {
        hero.GetHit(BaseDamage);
    }

    public void GetHit(int damege)
    {
        Hp -= damege;
    }
}

class Ml
{
    public static void MlMain()
    {
        Hero alucard = new Hero
        {
            Name = "Alucard",
            Hp = 1500,
            BaseDamage = 800
        };

        Hero cecilion = new Hero
        {
            Name = "Cecilion",
            Hp = 1000,
            BaseDamage = 500
        };
        
        alucard.Attack(cecilion);
        Console.WriteLine(cecilion.Hp);

        Monster minion = new Monster
        {
            Name = "Minion",
            Hp = 1000,
            BaseDemage = 100
        };
        
        alucard.Attack(minion);
        Console.WriteLine(minion.Hp);
    }
}