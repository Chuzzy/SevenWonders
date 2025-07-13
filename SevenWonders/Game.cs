class Game
{
    public readonly List<Player> Players = [];

    public Game(int playerCount)
    {
        for (int i = 0; i < playerCount; i++)
        {
            Players.Add(new Player());
        }
    }
}