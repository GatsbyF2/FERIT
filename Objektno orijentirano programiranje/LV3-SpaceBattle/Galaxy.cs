public class Galaxy
{
    Tile[,] tiles;
    public Galaxy(int x, int y)
    {
        Random generator = new Random();
        tiles = new Tile[x,y];
        for(int i=0; i<x; i++)
        {

            for(int j=0; j<y; j++)
            {
                Double randValue = generator.NextDouble();

                if (randValue <= 1)
                {
                    SpaceShip enemyShip;
                    if (generator.NextDouble() < 0.5)
                        enemyShip = new IlmoirShip();
                    else
                        enemyShip = new GaenShip();
                    tiles[i,j] = new AlienShipTile(enemyShip);
                }
                else
                {
                    tiles[i,j] = new Tile();
                }
            }
        }
    }
    public void NavigateTo(Fleet fleet, int x, int y)
    {
        tiles[x, y].StepOn(fleet);
    }
    public int EnemyAmountCheck(int x, int y)
    {
        return tiles[x, y].LiveEnemiesCount;
    }
}