public class Tile
{
    public virtual void StepOn(Fleet fleet) { }
    public virtual int LiveEnemiesCount { get { return 0; } }
}
