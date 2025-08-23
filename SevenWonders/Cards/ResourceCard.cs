namespace SevenWonders.Cards;

public class ResourceCard(string name, int age, CardCost cardCost, ResourceList providedResources) : Card(name, age, cardCost)
{
    /// <summary>
    /// An array representing the resources that this card can provide.
    /// The indices correspond to the Resource enum values.
    /// </summary>
    /// <value>Mutually exclusive list of resources that this card can provide.</value>
    public ResourceList ProvidedResouces { get; private set; } = providedResources;

    public override CardColor Color
    {
        get
        {
            // Must be a yellow card if it provides at least three resources.
            if (ProvidedResouces.NumberOfDifferentResources >= 3)
            {
                return CardColor.Yellow;
            }
            // Otherwise, if it provides any of either glass, paper or cloth, it is a gray card.
            else if (ProvidedResouces.Glass > 0 ||
                     ProvidedResouces.Paper > 0 ||
                     ProvidedResouces.Cloth > 0)
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
