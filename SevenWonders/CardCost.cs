namespace SevenWonders;

public readonly struct CardCost(ResourceList costs, int coins = 0, ChainingSymbol chainingSymbol = ChainingSymbol.None)
{
    public ResourceList Costs { get; } = costs;
    public int Coins { get; } = coins;
    public ChainingSymbol ChainingSymbol { get; } = chainingSymbol;

    public static CardCost None => new CardCost();
}
