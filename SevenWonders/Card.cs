namespace SevenWonders;

public abstract class Card(string name, int playerCount)
{
    public string Name { get; private set; } = name;

    public int PlayerCount { get; private set; } = playerCount;
}
