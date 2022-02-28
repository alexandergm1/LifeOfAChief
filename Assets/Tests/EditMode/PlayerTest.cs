using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTest
{
    Player player;

    [SetUp]
    public void Setup(){
        player = Player.InitializePlayer("Jack");

    }
    // A Test behaves as an ordinary method
    [Test]
    public void PlayerTestSimplePasses()
    {
    

        Assert.AreEqual("Jack", player.Name);

        
        // Use the Assert class to test conditions
    }
    [Test]
    public void CanSetGold(){

        player.Gold = 15F;
        Assert.AreEqual(15F, player.Gold);


    }
    [Test]
    public void CanIncreaseGold(){

        player.Gold = 15F;
        player.Gold += 5F;
        Assert.AreEqual(20F, player.Gold);
    }

    [Test]
    public void CanIncreaseGoldUsingMethod(){

        player.Gold = 15F;
        player.IncreaseGold(5F);
        Assert.AreEqual(20F, player.Gold);
    }



    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayerTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
