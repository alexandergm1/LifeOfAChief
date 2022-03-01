using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState
{
    public int Turn { get; set; }

    public GameState(){
        this.Turn = 0;
    }

    public static GameState InitializeGameState(){
        return new GameState();
    }

    public void EndTurn(Player player){
        this.Turn += 1;
        player.CollectIncome();
    }
}
