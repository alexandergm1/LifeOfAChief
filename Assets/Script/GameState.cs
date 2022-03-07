using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState
{
    void Start() {
    }


    public int Turn { get; set; }
    public Player player { get; set; }
    public Map map { get; set; }
    public static GameState Instance { get; private set;}


    public GameState(Player player, Map map){
        this.player = player;
        this.map = map;
        this.Turn = 0;
    }

    public static GameState InitializeGameState(Player player, Map map)
    {
        Instance = new GameState(player, map);
        return Instance;
    }

    public void EndTurn(){
        this.Turn += 1;
        this.player.CollectTotalIncome();
        this.player.Gold += 50;
        this.map.EndTurnReduceConstructionTime();
        this.map.EndTurnCheckBuildFinished();
        AdjustPopulationOnTurnEnd();
    }

    public void AdjustPopulationOnTurnEnd(){
        foreach (Village village in this.player.villages)
        {
            float randomNum = (((float) Random.Range(96, 105))/100);
            while (randomNum == 1F)
            {
                randomNum = (((float) Random.Range(96, 105))/100);
            }
            float population = village.Population;
            population *= randomNum;
            village.Population = (int) population;
        }
        foreach (Castle castle in this.player.castles)
        {
            float randomNum = (((float) Random.Range(96, 105))/100);
            while (randomNum == 1F)
            {
                randomNum = (((float) Random.Range(96, 105))/100);
            }
            float population = castle.Population;
            population *= randomNum;
            castle.Population = (int) population;
        }
    }

}