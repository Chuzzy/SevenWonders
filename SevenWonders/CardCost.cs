namespace SevenWonders;

public struct CardCost(int woodCost)
{
    private int woodCost = woodCost;
    public int WoodCost
    {
        readonly get => woodCost;
        set
        {
            if (value < 0)
                throw new ArgumentException("Wood cost cannot be less than 0.");

            woodCost = value;
        }
    }
}
