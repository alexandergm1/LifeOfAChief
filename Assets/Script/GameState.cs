using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState
{
    public ArrayList<Village> Villages;
    public int Turn;

    public GameState(){
        this.Villages = new ArrayList();
        this.Turn = 0;
    }

    private GameState(){
        this.Villages = new ArrayList();
        this.Turn = 0;
    }

    public static GameState InitializeGameState(){
            return new GameState();
    }
}
