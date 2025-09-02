namespace SevenWonders.Cards;

public class CoinAndPointCard(string name, int age, CardCost cardCost, CardColor targetColor) : Card(name, age, cardCost)
{
    public int ProvidedCoins => targetColor switch
    {
        CardColor.Yellow or CardColor.Brown => 1,
        CardColor.Gray => 2,
        CardColor.Red => 3,
        _ => 0,
    };

    public int ProvidedPoints => targetColor switch
    {
        CardColor.Yellow or CardColor.Brown or CardColor.Red => 1,
        CardColor.Gray => 2,
        _ => 0,
    };

    public override CardColor Color => CardColor.Yellow;
}
