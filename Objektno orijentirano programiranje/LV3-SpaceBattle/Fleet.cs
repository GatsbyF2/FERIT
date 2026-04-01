public class Fleet
{
    List<SpaceShip> ships;
    Translator translator;

    public Fleet(Translator translator)
    {
        this.translator = translator;
        ships = new List<SpaceShip>();   
    }
    public void AddShips(SpaceShip[] ships)
    {
        foreach(SpaceShip ship in ships)
        {
            this.ships.Add(ship);
        }
    }
    public void ChangeTranslator(Translator translator)
    {
        this.translator = translator;
    }
    public void Attack(SpaceShip target)
    {
        foreach (SpaceShip ship in ships)
        {
            ship.Attack(target);
        }
    }
    public void GetAttacked(SpaceShip attacker)
    {
        SpaceShip target = ships[0];
        for(int i=1; i<ships.Count; i++)
        {
            if (ships[i].Energy < target.Energy)
            {
                target = ships[i];
            }
        }
        attacker.Attack(target);
    }
    public string BroadCast(string message)
    {
        return translator.Translate(message);
    }
}
