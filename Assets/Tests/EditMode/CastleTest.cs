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
}
