namespace SevenWonders.Cards.GuildCards;

public class NeighborGuildCard(string name, CardCost cost, CardColor targetColor, int pointsPerCard = 1) : GuildCard(name, cost)
{
    public CardColor TargetColor { get; private set; } = targetColor;

    public int PointsPerCard { get; private set; } = pointsPerCard;
}
