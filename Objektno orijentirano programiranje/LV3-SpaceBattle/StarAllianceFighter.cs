public class StarAllianceFighter : SpaceShip
{
     private const int DeflectionBonus = 1;
    public int GunCount { get; private set; }
     public int GunPower { get; private set; }

    public StarAllianceFighter(int energy, int shields, int gunCount, int gunPower) : base(energy, shields)
     {
        GunCount = GunCount;
        GunPower = gunPower;
     }
     public override void Attack(SpaceShip target)
    {
         target.TakeDamage(GunCount * GunPower);
     }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage - DeflectionBonus);
    }
}
