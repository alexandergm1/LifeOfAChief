using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSite
{
    public string Name { get; set; }
    public int Population { get; set; }
    public TradeGood tradeGood{get; set;}
    public int GoldCost {get; set;}
    public int LumberCost {get; set;}
    public int BuildTime { get; set;}
    public bool UnderConstruction { get; set; }

    public BuildingSite(string name, int population, TradeGood tradeGood, int GoldCost, int LumberCost, int BuildTime){
        this.Name = name;
        this.Population = population;
        this.tradeGood = tradeGood;
        this.GoldCost = GoldCost;
        this.LumberCost = LumberCost;
        this.BuildTime = BuildTime;
        this.UnderConstruction = false;
    }   


    public static BuildingSite InitializeBuildingSite1()
    {
        return new BuildingSite("BuildingSite1", 600, TradeGood.LUMBER, 300, 300, 3);
    }

    public static BuildingSite InitializeBuildingSite2()
    {
        return new BuildingSite("BuildingSite2", 600, TradeGood.WHISKY, 1000, 600, 5);
    }

    public static BuildingSite InitializeBuildingSite3()
    {
        return new BuildingSite("BuildingSite3", 600, TradeGood.SEAWEED, 1000, 600, 5);
    }

       
    public static BuildingSite InitializeBuildingSite4()
    {
        return new BuildingSite("BuildingSite4", 500, TradeGood.LUMBER, 1200, 400, 6);
    }




}
