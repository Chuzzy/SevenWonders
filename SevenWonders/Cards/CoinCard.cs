namespace SevenWonders.Cards;

public class CoinCard(string name, int age, CardCost cardCost, int providedCoins, ChainingSymbol providedChainingSymbol = ChainingSymbol.None) : Card(name, age, cardCost, providedChainingSymbol)
{
    public int ProvidedCoins { get; private set; } = providedCoins;

    public override CardColor Color => CardColor.Yellow;
}
