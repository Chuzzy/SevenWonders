namespace SevenWonders;

public abstract class Card(string name, int age, CardCost cardCost, ChainingSymbol providedChainingSymbol = ChainingSymbol.None)
{
    public string Name { get; private set; } = name;

    public int Age { get; private set; } = age;

    public CardCost CardCost { get; private set; } = cardCost;

    public ChainingSymbol ProvidedChainingSymbol { get; private set; } = providedChainingSymbol;

    public abstract CardColor Color { get; }
}
