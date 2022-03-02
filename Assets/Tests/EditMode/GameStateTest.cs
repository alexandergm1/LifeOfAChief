using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GameStateTest
{
    Player player, player2;
    Village village, village2;
    GameState gameState;


    [SetUp]
    public void Setup()
    {
        player = Player.InitializePlayer("Jack");
        player2 = Player.InitializePlayer("Ron");
        village = Village.InitializeVillage("Limeric", TradeGood.SEALS);
        village2 = Village.InitializeVillage("Tukums", TradeGood.LUMBER);
        village.Population += 100;
        village2.Population += 200;
        player.AddVillage(village);
        player.AddVillage(village2);
        gameState = GameState.InitializeGameState(player);
    }

    [Test]
    public void TestEndTurn()
    {
        gameState.EndTurn();
        Assert.AreEqual(30, player.Gold);
        Assert.AreEqual(1, gameState.Turn);
    }
    [Test]
    public void TestAdjustPopulation()
    {
        gameState.AdjustPopulationOnTurnEnd();
        Assert.AreNotEqual(100, player.villages[0].Population);
    }
}
