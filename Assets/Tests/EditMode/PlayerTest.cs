using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTest
{
    Player player, player2;
    Village village, village2;
    Map map;

    [SetUp]
    public void Setup(){
        player = Player.InitializePlayer("Jack");
        player2 = Player.InitializePlayer("Ron");
        village = Village.InitializeVillage("Limeric", TradeGood.SEALS);
        village2 = Village.InitializeVillage("Tukums", TradeGood.LUMBER);
        map = Map.InitializeMap();
    }

    [Test]
    public void PlayerTestSecondPlayer()
    {
        Assert.AreEqual("Ron", player2.Name);
    }

    [Test]
    public void PlayerTestSimplePasses()
    {
        Assert.AreEqual("Jack", player.Name);
    }
    [Test]
    public void CanSetGold()
    {
        player.Gold = 15F;
        Assert.AreEqual(15F, player.Gold);
    }
    [Test]
    public void CanIncreaseGold()
    {
        player.Gold = 15F;
        player.Gold += 5F;
        Assert.AreEqual(20F, player.Gold);
    }

    [Test]
    public void CanIncreaseGoldUsingMethod()
    {
        player.Gold = 15F;
        player.IncreaseGold(5F);
        Assert.AreEqual(20F, player.Gold);
    }
    [Test]
    public void Has0StartingVillages()
    {
        Assert.AreEqual(0, player.villages.Count);
    }

    [Test]
    public void CanAddVillage()
    {
        player.AddVillage(village);
        player.AddVillage(village2);
        Assert.AreEqual(2, player.villages.Count);
        Assert.AreEqual("Tukums", player.villages[1].Name);
    }

    [Test]
    public void CanCollectLumberIncome()
    {
        player.AddVillage(village);
        player.AddVillage(village2);
        village.Population += 400;
        village2.Population += 200;
        player.CollectTotalIncome();
        Assert.AreEqual(160, player.Lumber);
    }

    [Test]
    public void CanCollectGoldIncome()
    {
        player.AddVillage(village);
        player.AddVillage(village2);
        village.Population += 400;
        village2.Population += 200;
        player.CollectTotalIncome();
        Assert.AreEqual(2360, player.Gold);
    }

    [Test]
    public void CanTakeControllOfVillageFromMap()
    {
        player.TakeControlOfVillageFromMap(map, "Village1");
        Assert.AreEqual(1, player.villages.Count);
    }

    [Test]
    public void CanBuildOnABuildingSite()
    {
        player.Gold = 2000;
        player.Lumber = 2000;
        BuildingSite buildingSite = BuildingSite.InitializeBuildingSite1();
        player.Build(buildingSite);
        Assert.AreEqual(true, buildingSite.UnderConstruction);
    }
}
