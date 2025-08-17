namespace SevenWonders.Cards;

public class CoinCard(string name, int playerCount, CardCost cardCost, ChainingSymbol providedChainingSymbol = ChainingSymbol.None) : Card(name, playerCount, cardCost, providedChainingSymbol)
{
    public override CardColor Color => CardColor.Yellow;
}
