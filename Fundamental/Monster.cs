namespace Fundamental;


// Overridding
public class Monster
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int BaseDemage { get; set; }

    public void GetHit(int demage)
    {
        Hp -= demage;
    }
}