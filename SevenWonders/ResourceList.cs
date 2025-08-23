namespace SevenWonders;

public struct ResourceList
{
    public ResourceList(int wood = 0, int stone = 0, int clay = 0, int ore = 0, int paper = 0, int glass = 0, int cloth = 0)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(wood);
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
        set => resources[(int)Resource.Wood] = value;
    }

    public int Stone
    {
        get => resources[(int)Resource.Stone];
        set => resources[(int)Resource.Stone] = value;
    }

    public int Clay
    {
        get => resources[(int)Resource.Clay];
        set => resources[(int)Resource.Clay] = value;
    }

    public int Ore
    {
        get => resources[(int)Resource.Ore];
        set => resources[(int)Resource.Ore] = value;
    }

    public int Paper
    {
        get => resources[(int)Resource.Paper];
        set => resources[(int)Resource.Paper] = value;
    }
    public int Glass
    {
        get => resources[(int)Resource.Glass];
        set => resources[(int)Resource.Glass] = value;
    }
    public int Cloth
    {
        get => resources[(int)Resource.Cloth];
        set => resources[(int)Resource.Cloth] = value;
    }
}
