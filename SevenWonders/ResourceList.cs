namespace SevenWonders;

public struct ResourceList
{
    public ResourceList(int wood = 0, int stone = 0, int clay = 0, int ore = 0, int paper = 0, int glass = 0, int cloth = 0)
    {
        Wood = wood;
        Stone = stone;
        Clay = clay;
        Ore = ore;
        Paper = paper;
        Glass = glass;
        Cloth = cloth;
    }

    private int[] resources = new int[7];

    public int Wood
    {
        get => resources[(int)Resource.Wood];
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            resources[(int)Resource.Wood] = value;
        }
    }

    public int Stone
    {
        get => resources[(int)Resource.Stone];
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            resources[(int)Resource.Stone] = value;
        }
    }

    public int Clay
    {
        get => resources[(int)Resource.Clay];
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            resources[(int)Resource.Clay] = value;
        }
    }

    public int Ore
    {
        get => resources[(int)Resource.Ore];
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            resources[(int)Resource.Ore] = value;
        }
    }

    public int Paper
    {
        get => resources[(int)Resource.Paper];
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            resources[(int)Resource.Paper] = value;
        }
    }
    public int Glass
    {
        get => resources[(int)Resource.Glass];
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            resources[(int)Resource.Glass] = value;
        }
    }
    public int Cloth
    {
        get => resources[(int)Resource.Cloth];
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            resources[(int)Resource.Cloth] = value;
        }
    }

    /// <summary>
    /// Returns the number of different resources in this list
    /// where the value is greater than 0.
    /// </summary>
    /// <returns>The number of different resources provided.</returns>
    public readonly int NumberOfDifferentResources => resources.Count(r => r > 0);
}
