public class StarAllianceScout : SpaceShip
{
    double dodgeChance;
    int laserDamage;
    Random generator = new Random();

    public StarAllianceScout(int energy, int shields, double dodgeChance, Int32 laserDamage, Random generator) : base(energy, shields)
    {
        this.dodgeChance = dodgeChance;
        this.laserDamage = laserDamage;
        this.generator = generator;
    }

    public override void Attack(SpaceShip target)
    {
        if (target.Shields == 0)
        {
            target.TakeDamage(laserDamage);
        }
    }
    public override void TakeDamage(int damage)
    {
        if ((float)generator.NextDouble() >= dodgeChance)
        {
            base.TakeDamage(damage);
        }
    }
    public override string ToString() => $"Scout E[{Energy}], S[{Shields}]";
}
