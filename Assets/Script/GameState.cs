using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState
{
    public int Turn;

    public GameState(){
        this.Turn = 0;
    }

    public static GameState InitializeGameState(){
        return new GameState();
    }
}
