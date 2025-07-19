namespace SevenWonders.Cards;

public class CivilianCard(string name, int playerCount, CardCost cardCost, int points) : Card(name, playerCount, cardCost)
{
    public int Points { get; private set; } = points;
}