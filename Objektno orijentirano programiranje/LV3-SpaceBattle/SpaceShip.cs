public abstract class SpaceShip
{
    public int Energy { get; private set; }
    public int Shields { get; private set; }
    protected SpaceShip(int energy, int shields)
    {
        this.Energy = energy;
        this.Shields = shields;
    }
     public virtual void TakeDamage(int damage)
     {
        int damageDone = damage - Shields;
        if (damageDone < 0)
        {
            Shields -= damage;
            return;
        }
        Shields = 0; ;
        Energy = Math.Max(0, Energy - damageDone);
    }
    public abstract void Attack(SpaceShip target);
    public virtual bool IsFlyable() => Energy > 0;
     public override string ToString() => $"Ship E[{Energy}], S[{Shields}]";
    }
