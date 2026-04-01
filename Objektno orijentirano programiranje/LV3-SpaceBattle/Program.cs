using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

RunDemo();
static void RunDemo()
{
    Random generator = new Random();
    SpaceShip[] ships = new SpaceShip[]
    {
        new StarAllianceScout(10, 0, 0.6, 1, generator),
        new StarAllianceHeavyBomber(100, 100, 15, 5, 30),
        new StarAllianceHeavyBomber(30, 0, 20, 5, 30),
        new StarAllianceScout(40, 100, 0.2, 3, generator),
        new StarAllianceHeavyBomber(100, 100, 18, 5, 30),
        new StarAllianceScout(50, 100, 0.4, 2, generator),
    };
    /* TODO - run battle simulation, display ships before and after the battle. */
    //prije bitke
    foreach (SpaceShip ship in ships)
    {
        Console.WriteLine(ship.ToString());
    }

    int survived = Simulation.Battle(ships);
    Console.WriteLine($"Survived ships: {survived}\n");

    foreach (SpaceShip ship in ships)
    {
        Console.WriteLine(ship.ToString());
    }
    //IlmoirTranslator gt = new IlmoirTranslator();
    //Console.WriteLine(gt.Translate("MAčrka"));

    
    Fleet bestFleet = new Fleet(new IlmoirTranslator());
    bestFleet.AddShips(ships);
    string message = "Are you ok?";
    Console.WriteLine($"English: {message}");
    Console.WriteLine($"Ilmoir: {bestFleet.BroadCast(message)}");
    
    bestFleet.ChangeTranslator(new GaenTranslator());
    Console.WriteLine($"Gaen: {bestFleet.BroadCast(message)}");


    //Generate Galaxy
    Galaxy galaxy = new Galaxy(10, 10);

    //Count enemy
    int enemyCount = 0;
    for(int i=0; i<10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if (i == j)
            {
                enemyCount += galaxy.EnemyAmountCheck(i, j);
            }
        }
    }
    Console.WriteLine($"Number of enemies before fleet expedition: {enemyCount}");
    enemyCount = 0;

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if (i == j)
            {
                galaxy.NavigateTo(bestFleet, i, j);
            }
        }
    }

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if (i == j)
            {
                enemyCount += galaxy.EnemyAmountCheck(i, j);
            }
        }
    }
    Console.WriteLine($"Number of enemies after fleet expedition: {enemyCount}");

}
