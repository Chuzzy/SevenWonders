namespace SevenWonders.Cards;

public class ResourceCard(string name, int playerCount, int age, CardCost cardCost) : Card(name, playerCount, age, cardCost)
{
    /// <summary>
    /// An array representing the resources that this card can provide.
    /// The indices correspond to the Resource enum values.
    /// </summary>
    /// <value>Mutually exclusive list of resources that this card can provide.</value>
    public int[] ProvidedResouces { get; private set; } = new int[7];

    public override CardColor Color
    {
        get
        {
            // Must be a yellow card if it provides at least three resources.
            if (ProvidedResouces.Count(r => r > 0) >= 3)
            {
                return CardColor.Yellow;
            }
            // Otherwise, if it provides any of either glass, paper or cloth, it is a gray card.
            else if (ProvidedResouces[(int)Resource.Glass] > 0 ||
                     ProvidedResouces[(int)Resource.Paper] > 0 ||
                     ProvidedResouces[(int)Resource.Cloth] > 0)
            {
                return CardColor.Gray;
            }
            // Otherwise, it is a brown card.
            else
            {
                return CardColor.Brown;
            }
        }
    }
}
