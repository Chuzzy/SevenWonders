namespace SevenWonders.Cards;

public class MilitaryCard(string name, int playerCount, int age, int militaryStrength, CardCost cardCost) : Card(name, playerCount, age, cardCost)
{
    public int MilitaryStrength { get; private set; } = militaryStrength;

    public override CardColor Color => CardColor.Red;
}