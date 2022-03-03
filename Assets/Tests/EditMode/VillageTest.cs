using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class VillageTest : MonoBehaviour
{

    Village village;
    Player player1;
    [SetUp]
    public void Setup(){
        player1 = Player.InitializePlayer("John");
        village = Village.InitializeVillage("Monet Ive", TradeGood.SEALS);
    }
    // A Test behaves as an ordinary method
    [Test]
    public void VillageCanPayPlayer()
    {
        village.PayPlayer(player1, 20F);
        Assert.AreEqual(320F, player1.Gold);
    }

    [Test]
    public void VillageHasTradeGood(){
        Assert.AreEqual(TradeGood.SEALS, village.tradeGood);
    }

    [Test]
    public void VillageTradeGoodHasValue(){
        Assert.AreEqual(10, (int) village.tradeGood);
    }

    [Test]
    public void VillageCanCalculatePopTax(){
        village.Population += 46;
        Assert.AreEqual(4, village.CalculatePopTax());
    }

    [Test]
    public void VillageUpgradeLevelAffectsTax()
    {
        village.UpgradeLevel += 4;
        village.Population += 1000;
        Assert.AreEqual(180, village.CalculatePopTax());
    }

    [Test]
    public void canSetVillageTax()
    {
        village.Tax = 20;
        village.Population = 1000;
        Assert.AreEqual(200, village.CalculatePopTax());
    }

}
