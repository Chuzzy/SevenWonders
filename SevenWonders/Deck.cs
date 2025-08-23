namespace SevenWonders;

using SevenWonders.Cards;

static class Deck
{
    static Dictionary<Card, PlayerCount> allCards = new Dictionary<Card, PlayerCount>
    {
        #region Brown Cards - Age I
        { new ResourceCard("Lumber Yard", 1, CardCost.None, new ResourceList { Wood = 1 }), PlayerCount.Three | PlayerCount.Four },
        { new ResourceCard("Ore Vein", 1, CardCost.None, new ResourceList { Ore = 1 }), PlayerCount.Three | PlayerCount.Four },
        { new ResourceCard("Stone Pit", 1, CardCost.None, new ResourceList { Stone = 1 }), PlayerCount.Three | PlayerCount.Five },
        { new ResourceCard("Clay Pool", 1, CardCost.None, new ResourceList { Clay = 1 }), PlayerCount.Three | PlayerCount.Five },
        { new ResourceCard("Timber Yard", 1, new CardCost(ResourceList.Empty, 1), new ResourceList { Wood = 1, Stone = 1 }), PlayerCount.Three },
        { new ResourceCard("Clay Pit", 1, new CardCost(ResourceList.Empty, 1), new ResourceList { Ore = 1, Clay = 1 }), PlayerCount.Three },
        { new ResourceCard("Excavation", 1, new CardCost(ResourceList.Empty, 1), new ResourceList { Stone = 1, Clay = 1 }), PlayerCount.Four },
        { new ResourceCard("Forest Cave", 1, new CardCost(ResourceList.Empty, 1), new ResourceList { Wood = 1, Ore = 1 }), PlayerCount.Five },
        { new ResourceCard("Tree Farm", 1, new CardCost(ResourceList.Empty, 1), new ResourceList { Wood = 1, Clay = 1 }), PlayerCount.Six },
        { new ResourceCard("Mine", 1, new CardCost(ResourceList.Empty, 1), new ResourceList { Stone = 1, Ore = 1 }), PlayerCount.Six },
        #endregion

        #region Brown Cards - Age II
        { new ResourceCard("Sawmill", 2, new CardCost(ResourceList.Empty, 1), new ResourceList { Wood = 2 }), PlayerCount.Three | PlayerCount.Four },
        { new ResourceCard("Foundry", 2, new CardCost(ResourceList.Empty, 1), new ResourceList { Ore = 2 }), PlayerCount.Three | PlayerCount.Four },
        { new ResourceCard("Quarry", 2, new CardCost(ResourceList.Empty, 1), new ResourceList { Stone = 2 }), PlayerCount.Three | PlayerCount.Four },
        { new ResourceCard("Brickyard", 2, new CardCost(ResourceList.Empty, 1), new ResourceList { Clay = 2 }), PlayerCount.Three | PlayerCount.Four },
        #endregion

        #region Grey Cards - Age I
        { new ResourceCard("Glassworks", 1, CardCost.None, new ResourceList { Glass = 1 }), PlayerCount.Three | PlayerCount.Six },
        { new ResourceCard("Press", 1, CardCost.None, new ResourceList { Paper = 1 }), PlayerCount.Three | PlayerCount.Six },
        { new ResourceCard("Loom", 1, CardCost.None, new ResourceList { Cloth = 1 }), PlayerCount.Three | PlayerCount.Six },
        #endregion
        
        #region Grey Cards - Age II
        { new ResourceCard("Glassworks", 2, CardCost.None, new ResourceList { Glass = 1 }), PlayerCount.Three | PlayerCount.Five },
        { new ResourceCard("Press", 2, CardCost.None, new ResourceList { Paper = 1 }), PlayerCount.Three | PlayerCount.Five },
        { new ResourceCard("Loom", 2, CardCost.None, new ResourceList { Cloth = 1 }), PlayerCount.Three | PlayerCount.Five },
        #endregion
    };


}
