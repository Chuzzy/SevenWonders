namespace SevenWonders.Cards;

public class CoinCard(string name, int age, CardCost cardCost, ChainingSymbol providedChainingSymbol = ChainingSymbol.None) : Card(name, age, cardCost, providedChainingSymbol)
{
    public override CardColor Color => CardColor.Yellow;
}
