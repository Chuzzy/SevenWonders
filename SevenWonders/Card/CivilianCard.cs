namespace SevenWonders.Cards;

public class CivilianCard(string name, int playerCount, int points) : Card(name, playerCount)
{
    public int Points { get; private set; } = points;
}