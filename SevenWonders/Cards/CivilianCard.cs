namespace SevenWonders.Cards;

public class CivilianCard(string name, int age, CardCost cardCost, int points) : Card(name, age, cardCost)
{
    public int Points { get; private set; } = points;

    public override CardColor Color => CardColor.Blue;
}