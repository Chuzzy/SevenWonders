namespace SevenWonders.Cards;

public class ScienceCard(string name, int age, CardCost cardCost, ScienceSymbol symbol) : Card(name, age, cardCost)
{
    public ScienceSymbol Symbol { get; private set; } = symbol;

    public override CardColor Color => Symbol == ScienceSymbol.Wild ? CardColor.Purple : CardColor.Green;
}
