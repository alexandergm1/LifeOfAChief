using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village
{
    public string Name { get; set; }
    public int Population { get; set; }
    public TradeGood tradeGood{get; set;}
    public int UpgradeLevel{get; set;}

    public Village(string name, int population, TradeGood tradeGood, int UpgradeLevel){
        this.Name = name;
        this.Population = population;
        this.tradeGood = tradeGood;
        this.UpgradeLevel = UpgradeLevel;
    }

    private Village(string name, TradeGood tradeGood){
        this.Name = name;
        this.Population = 0;
        this.tradeGood = tradeGood;
        this.UpgradeLevel = 0;
    }

    public static Village InitializeVillage(string name, TradeGood tradeGood){
        return new Village(name, tradeGood);
    }

    public void PayPlayer(Player player, float amount){
        player.IncreaseGold(amount);
    }

    public int CalculatePopTax(){
        return (int)(this.Population * 0.1 * ((this.UpgradeLevel * 0.2) + 1)) ;
    }

    // public float CalculateResourceTax(){
    //     if (this.tradeGood != TradeGood.LUMBER)
    // }

    

}
