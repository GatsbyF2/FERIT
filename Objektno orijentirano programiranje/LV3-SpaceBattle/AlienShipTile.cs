public class AlienShipTile : Tile
{
    private SpaceShip spaceShip;
    bool alive;
    public AlienShipTile(SpaceShip spaceShip)
     {
        this.spaceShip = spaceShip;
        alive = true;
     }

     public override void StepOn(Fleet fleet)
     {
         fleet.GetAttacked(spaceShip);
         fleet.Attack(spaceShip);
        if (spaceShip.Energy <= 0)
        {
            alive = false;
        }
     }

     public override int LiveEnemiesCount => alive ? 1 : 0;
}
