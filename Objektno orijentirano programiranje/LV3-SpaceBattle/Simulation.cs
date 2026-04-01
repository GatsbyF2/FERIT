public static class Simulation
{

    public static int Battle(SpaceShip[] ships)
    {
        for(int i=0;i<ships.Length; i++)
        {
            for (int j = 0; j < ships.Length; j++)
            {
                if (i != j)
                {
                    ships[i].Attack(ships[j]);
                }
            }
        }
        int survivedShipsCount = 0;
        for (int i = 0; i < ships.Length; i++)
        {
            if (ships[i].Energy > 0) survivedShipsCount++;
        }
        return survivedShipsCount;
    }
}