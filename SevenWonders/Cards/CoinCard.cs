namespace SevenWonders.Cards;

public class CoinCard(string name, int playerCount, int age, CardCost cardCost, ChainingSymbol providedChainingSymbol = ChainingSymbol.None) : Card(name, playerCount, age, cardCost, providedChainingSymbol)
{
    public override CardColor Color => CardColor.Yellow;
}
