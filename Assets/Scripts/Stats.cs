[System.Serializable]
public class Stats
{
    public int Atk { get; set; }
    public int Def { get; set; }
    public int Hp { get; set; }
    public int Critical { get; set; }

    public Stats()
    {
        Atk = 0;
        Def = 0;
        Hp = 0;
        Critical = 0;
    }

    public void Add(Stats stats)
    {
        Atk += stats.Atk;
        Def += stats.Def;
        Hp += stats.Hp;
        Critical += stats.Critical;
    }
}
