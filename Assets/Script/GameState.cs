using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static Player player;

    void Start() {
    }


    public int Turn { get; set; }

    public GameState(){
        this.Turn = 0;
    }

    public static GameState InitializeGameState(){
        return new GameState();
    }

    public void EndTurn(){
        this.Turn += 1;
        player.CollectIncome();
    }
}
