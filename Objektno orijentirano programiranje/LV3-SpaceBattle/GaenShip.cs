class GaenShip : SpaceShip
 {
     private int peacefulWayOfForce;
     private int diplomacy;
     public GaenShip(int energy = 20, int shields = 50, int peacefulWayOfForce = 5, int diplomacy = 2)
     : base(energy, shields)
     {
     this.peacefulWayOfForce = peacefulWayOfForce;
     this.diplomacy = diplomacy;
     }

     public override void Attack(SpaceShip target)
     {
         target.TakeDamage(diplomacy * peacefulWayOfForce);
      }
 }
