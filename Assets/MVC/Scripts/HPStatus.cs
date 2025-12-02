using UnityEngine;

public class HPStatus
{
    private int maxHp = 7;
    
    public int Hp { get; private set; }
    
    public HPStatus()
    {
        Hp = maxHp;
    }

    public void Damage()
    {
        if (Hp > 0)
        {
            Hp--;
        }
        Debug.Log(Hp);
    }

    public void Heal()
    {
        if (Hp < 7)
        {
            Hp++;
        }
        Debug.Log(Hp);
    }
}
