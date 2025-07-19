namespace SevenWonders.Cards;

public class MilitaryCard(string name, int playerCount, int militaryStrength, CardCost cardCost) : Card(name, playerCount, cardCost)
{
    public int MilitaryStrength { get; private set; } = militaryStrength;
}