using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CastleTest
{

    Castle castle;
    Player player1;
    [SetUp]
    public void Setup(){
        player1 = Player.InitializePlayer("John");
        castle = Castle.InitializeCastle("Edinburgh Castle");
    }
    // A Test behaves as an ordinary method
    [Test]
    public void CastleCanPlayPlayer()
    {
        castle.PayPlayer(player1, 20F);
        
        Assert.AreEqual(20F, player1.Gold);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CastleTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
