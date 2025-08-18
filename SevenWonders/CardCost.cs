namespace SevenWonders;

public readonly struct CardCost(ResourceList costs, ChainingSymbol chainingSymbol = ChainingSymbol.None)
{
    public ResourceList Costs { get; } = costs;
    public ChainingSymbol ChainingSymbol { get; } = chainingSymbol;

    public static CardCost None => new CardCost();
}
