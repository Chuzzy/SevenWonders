class CivilianCard(int playerCount, int points) : Card(playerCount)
{
    public int Points { get; private set; } = points;
}