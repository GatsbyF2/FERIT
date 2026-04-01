public class IlmoirShip : SpaceShip
 {
     private int sonarBlastDamage;
     public IlmoirShip(int energy = 20, int shields = 50, int sonarBlastDamage = 3) : base(energy, shields)
     {
     this.sonarBlastDamage = sonarBlastDamage;
     }

     public override void Attack(SpaceShip target)
     {
         target.TakeDamage(sonarBlastDamage);
     }
 }
