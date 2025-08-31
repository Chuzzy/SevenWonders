namespace SevenWonders.Cards;

public class MilitaryCard(string name, int age, CardCost cardCost, int militaryStrength) : Card(name, age, cardCost)
{
    public int MilitaryStrength { get; private set; } = militaryStrength;

    public override CardColor Color => CardColor.Red;
}