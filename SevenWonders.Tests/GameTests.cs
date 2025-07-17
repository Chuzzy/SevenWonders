namespace SevenWonders.Tests;

using SevenWonders;

[TestClass]
public sealed class GameTests
{
    [TestMethod]
    public void Game_Constructor_CreatesGameWithCorrectNumberOfCards()
    {
        var game = new Game(3);

        Assert.AreEqual(3, game.Players.Count);
    }
}
