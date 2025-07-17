namespace SevenWonders.Cards;

public class MilitaryCard(string name, int playerCount, int militaryStrength) : Card(name, playerCount)
{
    public int MilitaryStrength { get; private set; } = militaryStrength;
}