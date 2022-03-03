using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState
{
    void Start() {
    }


    public int Turn { get; set; }
    public Player player { get; set; }
    public static GameState Instance { get; private set;}


    public GameState(Player player){
        this.player = player;
        this.Turn = 0;
    }

    public static GameState InitializeGameState(Player player)
    {
        Instance = new GameState(player);
        return Instance;
    }

    public void EndTurn(){
        this.Turn += 1;
        this.player.CollectTotalIncome();
        this.player.Gold += 50;
    }

    public void AdjustPopulationOnTurnEnd(){
        foreach (Village village in this.player.villages)
        {
            float randomNum = (((float) Random.Range(90, 110))/100);
            while (randomNum == 1F)
            {
                randomNum = (((float) Random.Range(90, 110))/100);
            }
            float population = village.Population;
            population *= randomNum;
            village.Population = (int) population;
        }
    }

}