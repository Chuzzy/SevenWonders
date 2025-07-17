public class Player
{
    public int Score
    {
        get
        {
            return MilitaryTokens.Sum() + CivilianCards.Sum(card => card.Points);
        }
    }

    /// <summary>
    /// Military conflict tokens. Either -1, 1, 3 or 5.
    /// </summary>
    public readonly List<int> MilitaryTokens = [];

    /// <summary>
    /// List of cards this player has built.
    /// </summary>
    public readonly List<Card> BuiltCards = [];

    /// <summary>
    /// List of cards this player has in their hand.
    /// </summary>
    public readonly List<Card> CardsInHand = [];

    public IEnumerable<CivilianCard> CivilianCards => (IEnumerable<CivilianCard>)BuiltCards.Where(card => card is CivilianCard);

    public IEnumerable<MilitaryCard> MilitaryCards => (IEnumerable<MilitaryCard>)BuiltCards.Where(card => card is MilitaryCard);
}
