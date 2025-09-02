namespace SevenWonders.Cards;

public class NeighborCoinCard(string name, int age, CardColor targetColor, int coinsAwarded) : Card(name, age, CardCost.None)
{
    public CardColor TargetColor { get; private set; } = targetColor;

    public int CoinsAwarded { get; private set; } = coinsAwarded;

    public override CardColor Color => CardColor.Yellow;
}
