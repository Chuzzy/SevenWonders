namespace SevenWonders.Cards;

public abstract class GuildCard(string name, CardCost cost) : Card(name, 3, cost)
{
    public override CardColor Color => CardColor.Purple;
}
