namespace SevenWonders.Cards;

public class CoinsAndPointsForWonderStagesCard(string name, int age, CardCost cost) : Card(name, age, cost)
{
    public override CardColor Color => CardColor.Yellow;
}