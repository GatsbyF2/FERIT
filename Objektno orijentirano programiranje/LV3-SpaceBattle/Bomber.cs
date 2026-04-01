public class StarAllianceHeavyBomber : SpaceShip
{
    const int burstScale = 20;
    int bombAmount;
    int bombDamage;
    int bonusShield;

    public StarAllianceHeavyBomber(int energy, int shields, Int32 bombAmount, Int32 bombDamage, Int32 bonusShield) : base(energy, shields)
    {
        this.bombAmount = bombAmount;
        this.bombDamage = bombDamage;
        this.bonusShield = bonusShield;
    }
    public override void Attack(SpaceShip target)
    {
        if (bombAmount > 0)
        {
            if (target.Shields == 0)
            {
                target.TakeDamage(bombDamage* burstScale);
            }
            else target.TakeDamage(bombDamage);

            bombAmount--;
        }
    }
    public override void TakeDamage(int damage)
    {
        if (bonusShield > 0)
        {
            int remaining = damage - bonusShield;
            bonusShield -= damage;

            if (remaining > 0)
            {
                base.TakeDamage(remaining);
            }
        }
        else
        {
            base.TakeDamage(damage);
        }
    }
    public override string ToString() => $"Bomber E[{Energy}], S[{Shields}]";
}
