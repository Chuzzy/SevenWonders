namespace SevenWonders.Cards.GuildCards;

public class NeighbourGuildCard(string name, CardCost cost, CardColor targetColor) : GuildCard(name, cost)
{
    public CardColor TargetColor { get; private set; } = targetColor;
}
