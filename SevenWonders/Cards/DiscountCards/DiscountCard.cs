namespace SevenWonders.Cards.DiscountCards;

/// <summary>
/// A card which provides a discount when buying resources from a neighbor.
/// </summary>
/// <param name="name">The name of the card.</param>
/// <param name="age">Which age the card appears in - one, two or three.</param>
/// <param name="cardCost">Cost to build the card.</param>
/// <param name="discountedNeighbour">The neightbor to apply the discount to.</param>
/// <param name="discountedResources">The list of resources which are discounted.</param>
public class DiscountCard(string name, int age, CardCost cardCost, Neighbor discountedNeighbour, ResourceList discountedResources) : Card(name, age, cardCost)
{
    /// <summary>
    /// The neighbor whose resources are discounted.
    /// </summary>
    public Neighbor Neighbor { get; private set; } = discountedNeighbour;

    /// <summary>
    /// The resources which are discounted.
    /// </summary>
    public ResourceList DiscountedResources { get; private set; } = discountedResources;

    /// <summary>
    /// The color of the card.
    /// </summary>
    /// <value>Yellow</value>
    public override CardColor Color { get; } = CardColor.Yellow;
}
