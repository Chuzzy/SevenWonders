namespace SevenWonders;

public readonly struct CardCost(int[] costs, ChainingSymbol chainingSymbol = ChainingSymbol.None)
{
    public int[] Costs { get; } = costs;
    public ChainingSymbol ChainingSymbol { get; } = chainingSymbol;
}
