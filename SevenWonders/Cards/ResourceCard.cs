namespace SevenWonders.Cards;

public class ResourceCard(string name, int playerCount, CardCost cardCost) : Card(name, playerCount, cardCost)
{
    /// <summary>
    /// An array representing the resources that this card can provide.
    /// The indices correspond to the Resource enum values.
    /// </summary>
    /// <value>Mutually exclusive list of resources that this card can provide.</value>
    public int[] ProvidedResouces { get; private set; } = new int[7];
}
