namespace SevenWonders;

using SevenWonders.Cards;
using SevenWonders.Cards.DiscountCards;
using SevenWonders.Cards.GuildCards;


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
        { new CivilianCard("Palace", 3, new CardCost(new ResourceList { Wood = 1, Stone = 1, Ore = 1, Clay = 1, Glass = 1, Paper = 1, Cloth = 1 }), 8), PlayerCount.Three | PlayerCount.Seven },
        #endregion

        #region Yellow Cards - Age I
        { new CoinCard("Tavern", 1, CardCost.None, 5), PlayerCount.Four | PlayerCount.Five | PlayerCount.Seven },
        { new DiscountCard("West Trading Post", 1, CardCost.None, Neighbor.Left, new ResourceList { Wood = 1, Stone = 1, Ore = 1, Clay = 1 }), PlayerCount.Three | PlayerCount.Seven },
        { new DiscountCard("East Trading Post", 1, CardCost.None, Neighbor.Left, new ResourceList { Wood = 1, Stone = 1, Ore = 1, Clay = 1 }), PlayerCount.Three | PlayerCount.Seven },
        { new DiscountCard("Marketplace", 1, CardCost.None, Neighbor.Right, new ResourceList { Wood = 1, Stone = 1, Ore = 1, Clay = 1 }), PlayerCount.Three | PlayerCount.Six },
        #endregion

        #region Yellow Cards - Age II
        { new ResourceCard("Caravansery", 2, new CardCost(new ResourceList { Wood = 2 }), new ResourceList { Wood = 1, Stone = 1, Ore = 1, Clay = 1 }), PlayerCount.Three | PlayerCount.Five | PlayerCount.Six },
        { new ResourceCard("Forum", 2, new CardCost(new ResourceList { Clay = 2 }), new ResourceList { Glass = 1, Paper = 1, Cloth = 1}), PlayerCount.Three | PlayerCount.Six | PlayerCount.Seven },
        { new NeighborCoinCard("Vineyard", 2, CardColor.Brown, 1), PlayerCount.Three | PlayerCount.Six },
        { new NeighborCoinCard("Bazaar", 2, CardColor.Gray, 2), PlayerCount.Four | PlayerCount.Seven },
        #endregion

        #region Yellow Cards - Age III
        { new CoinAndPointCard("Lighthouse", 3, new CardCost(new ResourceList { Stone = 1, Glass = 1 }), CardColor.Yellow), PlayerCount.Three | PlayerCount.Six },
        { new CoinAndPointCard("Haven", 3, new CardCost(new ResourceList { Wood = 1, Ore = 1, Cloth = 1 }), CardColor.Brown), PlayerCount.Three | PlayerCount.Four },
        { new CoinAndPointCard("Chamber of Commerce", 3, new CardCost(new ResourceList { Clay = 2, Paper = 1 }), CardColor.Gray), PlayerCount.Four | PlayerCount.Six },
        { new CoinAndPointCard("Ludus", 3, new CardCost(new ResourceList { Stone = 2, Paper = 1 }), CardColor.Gray), PlayerCount.Five | PlayerCount.Seven },
        { new CoinsAndPointsForWonderStagesCard("Arena", 3, new CardCost(new ResourceList { Clay = 2, Ore = 1 })), PlayerCount.Three | PlayerCount.Five },
        #endregion

        #region Red Cards - Age I
        { new MilitaryCard("Guard Tower", 1, new CardCost(new ResourceList { Clay = 1 }), 1), PlayerCount.Three | PlayerCount.Four },
        { new MilitaryCard("Barracks", 1, new CardCost(new ResourceList { Ore = 1 }), 1), PlayerCount.Three | PlayerCount.Five },
        { new MilitaryCard("Stockade", 1, new CardCost(new ResourceList { Wood = 1 }), 1), PlayerCount.Three | PlayerCount.Seven },
        #endregion

        #region Red Cards - Age II
        { new MilitaryCard("Stables", 2, new CardCost(new ResourceList { Wood = 1, Ore = 1, Clay = 1 }), 2), PlayerCount.Three | PlayerCount.Five },
        { new MilitaryCard("Archery Range", 2, new CardCost(new ResourceList { Wood = 2, Ore = 1 }), 2), PlayerCount.Three | PlayerCount.Six },
        { new MilitaryCard("Walls", 2, new CardCost(new ResourceList { Stone = 3 }), 3), PlayerCount.Three | PlayerCount.Seven },
        { new MilitaryCard("Training Ground", 2, new CardCost(new ResourceList { Ore = 2, Wood = 1 }), 2), PlayerCount.Four | PlayerCount.Six | PlayerCount.Seven },
        #endregion

        #region Red Cards - Age III
        { new MilitaryCard("Arsenal", 3, new CardCost(new ResourceList { Wood = 2, Ore = 1, Cloth = 1 }), 3), PlayerCount.Three | PlayerCount.Five },
        { new MilitaryCard("Siege Workshop", 3, new CardCost(new ResourceList { Clay = 3, Wood = 1 }), 3), PlayerCount.Three | PlayerCount.Five },
        { new MilitaryCard("Fortificaitons", 3, new CardCost(new ResourceList { Ore = 3, Clay = 1 }), 3), PlayerCount.Three | PlayerCount.Seven },
        { new MilitaryCard("Circus", 3, new CardCost(new ResourceList { Clay = 3, Ore = 1 }), 3), PlayerCount.Four | PlayerCount.Six },
        { new MilitaryCard("Castrum", 3, new CardCost(new ResourceList { Clay = 2, Wood = 1, Paper = 1 }), 3), PlayerCount.Four | PlayerCount.Seven },
        #endregion

        #region Green Cards - Age I
        { new ScienceCard("Scriptorium", 1, new CardCost(new ResourceList { Paper = 1 }), ScienceSymbol.Tablet), PlayerCount.Three | PlayerCount.Four },
        { new ScienceCard("Apothecary", 1, new CardCost(new ResourceList { Cloth = 1 }), ScienceSymbol.Compass), PlayerCount.Three | PlayerCount.Five },
        { new ScienceCard("Workshop", 1, new CardCost(new ResourceList { Glass = 1 }), ScienceSymbol.Wheel), PlayerCount.Three | PlayerCount.Seven },
        #endregion

        #region Green Cards - Age II
        { new ScienceCard("Dispensary", 2, new CardCost(new ResourceList { Ore = 2, Glass = 1 }), ScienceSymbol.Compass), PlayerCount.Three | PlayerCount.Four },
        { new ScienceCard("Laboratory", 2, new CardCost(new ResourceList { Clay = 2, Paper = 1 }), ScienceSymbol.Wheel), PlayerCount.Three | PlayerCount.Five },
        { new ScienceCard("Library", 2, new CardCost(new ResourceList { Stone = 2, Cloth = 1 }), ScienceSymbol.Tablet), PlayerCount.Three | PlayerCount.Six },
        { new ScienceCard("School", 2, new CardCost(new ResourceList { Wood = 1, Paper = 1 }), ScienceSymbol.Tablet), PlayerCount.Three | PlayerCount.Seven },
        #endregion

        #region Green Cards - Age III
        { new ScienceCard("University", 3, new CardCost(new ResourceList { Wood = 2, Glass = 1, Paper = 1 }), ScienceSymbol.Tablet), PlayerCount.Three | PlayerCount.Four },
        { new ScienceCard("Study", 3, new CardCost(new ResourceList { Wood = 1, Glass = 1, Paper = 1 }), ScienceSymbol.Wheel), PlayerCount.Three | PlayerCount.Five },
        { new ScienceCard("Lodge", 3, new CardCost(new ResourceList { Clay = 2, Cloth = 1, Paper = 1 }), ScienceSymbol.Compass), PlayerCount.Three | PlayerCount.Six },
        { new ScienceCard("Academy", 3, new CardCost(new ResourceList { Stone = 3, Glass = 1 }), ScienceSymbol.Compass), PlayerCount.Three | PlayerCount.Seven },
        { new ScienceCard("Observatory", 3, new CardCost(new ResourceList { Ore = 2, Glass = 1, Cloth = 1 }), ScienceSymbol.Wheel), PlayerCount.Three | PlayerCount.Seven },
        #endregion

        #region Purple Cards - Age III
        // TODO: add Decorators, Builders guilds
        { new NeighborGuildCard("Workers Guild", new CardCost(new ResourceList { Ore = 2, Wood = 1, Stone = 1, Clay = 1 }), CardColor.Brown), PlayerCount.Guild },
        { new NeighborGuildCard("Craftsmens Guild", new CardCost(new ResourceList { Stone = 2, Ore = 1 }), CardColor.Gray, 2), PlayerCount.Guild },
        { new NeighborGuildCard("Magistrates Guild", new CardCost(new ResourceList { Wood = 3, Stone = 1, Cloth = 1 }), CardColor.Blue), PlayerCount.Guild },
        { new NeighborGuildCard("Traders Guild", new CardCost(new ResourceList { Glass = 1, Paper = 1, Cloth = 1 }), CardColor.Yellow), PlayerCount.Guild },
        { new NeighborGuildCard("Spies Guild", new CardCost(new ResourceList { Clay = 2, Glass = 1 }), CardColor.Red), PlayerCount.Guild },
        { new NeighborGuildCard("Philosophers Guild", new CardCost(new ResourceList { Clay = 2, Paper = 1, Cloth = 1 }), CardColor.Green), PlayerCount.Guild },
        { new CoinAndPointCard("Shipowners Guild", 3, new CardCost(new ResourceList { Wood = 3, Glass = 1, Paper = 1 }), CardColor.Brown | CardColor.Gray | CardColor.Purple), PlayerCount.Guild },
        { new ScienceCard("Scientists Guild", 3, new CardCost(new ResourceList { Wood = 2, Ore = 2, Paper = 1 }), ScienceSymbol.Wild), PlayerCount.Guild },
        { new CompletedWonderCard("Decorators Guild", new CardCost(new ResourceList { Ore = 2, Stone = 1, Cloth = 1 })), PlayerCount.Guild },
        { new NeighborWonderCard("Builders Guild", new CardCost(new ResourceList { Stone = 3, Clay = 2, Glass = 1 } )), PlayerCount.Guild },
        #endregion
    };


}
