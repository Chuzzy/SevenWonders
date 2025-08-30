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

        #region Blue Cards - Age I
        { new CivilianCard("Altar", 1, CardCost.None, 3), PlayerCount.Three | PlayerCount.Five },
        { new CivilianCard("Theater", 1, CardCost.None, 3), PlayerCount.Three | PlayerCount.Six },
        { new CivilianCard("Well", 1, CardCost.None, 3), PlayerCount.Four | PlayerCount.Seven },
        { new CivilianCard("Baths", 1, new CardCost(new ResourceList { Stone = 1 }), 3), PlayerCount.Four | PlayerCount.Seven },
        #endregion

        #region Blue Cards - Age II
        { new CivilianCard("Courthouse", 2, new CardCost(new ResourceList { Clay = 2, Cloth = 1 }), 4), PlayerCount.Three | PlayerCount.Five },
        { new CivilianCard("Temple", 2, new CardCost(new ResourceList { Wood = 1, Clay = 1, Glass = 1 }), 4), PlayerCount.Three | PlayerCount.Six },
        { new CivilianCard("Statue", 2, new CardCost(new ResourceList { Ore = 2, Wood = 1 }), 4), PlayerCount.Three | PlayerCount.Seven },
        { new CivilianCard("Aqueduct", 2, new CardCost(new ResourceList { Stone = 3 }), 5), PlayerCount.Three | PlayerCount.Seven },
        #endregion
        
        #region Blue Cards - Age III
        { new CivilianCard("Gardens", 3, new CardCost(new ResourceList { Clay = 2, Wood = 1 }), 5), PlayerCount.Three | PlayerCount.Four },
        { new CivilianCard("Senate", 3, new CardCost(new ResourceList { Wood = 2, Stone = 1, Clay = 1 }), 6), PlayerCount.Three | PlayerCount.Five },
        { new CivilianCard("Town Hall", 3, new CardCost(new ResourceList { Stone = 3, Glass = 1 }), 6), PlayerCount.Three | PlayerCount.Six },
        { new CivilianCard("Pantheon", 3, new CardCost(new ResourceList { Clay = 2, Ore = 1, Glass = 1, Paper = 1, Cloth = 1 }), 7), PlayerCount.Three | PlayerCount.Six },
        { new CivilianCard("Palace", 3, new CardCost(new ResourceList { Wood = 1, Stone = 1, Ore = 1, Clay = 1, Glass = 1, Paper = 1, Cloth = 1 }), 8), PlayerCount.Three | PlayerCount.Seven }
        #endregion
    };


}
