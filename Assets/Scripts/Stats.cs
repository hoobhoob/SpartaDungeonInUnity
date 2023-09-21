[System.Serializable]
public class Stats
{
    public int atk;
    public int def;
    public int hp;
    public int critical;

    public Stats()
    {
        atk = 0;
        def = 0;
        hp = 0;
        critical = 0;
    }

    public void Add(Stats stats)
    {
        atk += stats.atk;
        def += stats.def;
        hp += stats.hp;
        critical += stats.critical;
    }

    public void Subtract(Stats stats)
    {
        atk -= stats.atk;
        def -= stats.def;
        hp -= stats.hp;
        critical -= stats.critical;
    }
}
