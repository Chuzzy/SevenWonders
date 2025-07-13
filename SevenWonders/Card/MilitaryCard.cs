class MilitaryCard(int playerCount, int militaryStrength) : Card(playerCount)
{
    public int MilitaryStrength { get; private set; } = militaryStrength;
}