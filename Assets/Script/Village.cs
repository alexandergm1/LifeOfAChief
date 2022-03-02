using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village
{
    public string Name { get; set; }
    public int Population { get; set; }
    public TradeGood tradeGood{get; set;}
    public int UpgradeLevel{get; set;}
    public int UpgradeCounter {get; set;}

    public Village(string name, int population, TradeGood tradeGood, int UpgradeLevel, int UpgradeCounter){
        this.Name = name;
        this.Population = population;
        this.tradeGood = tradeGood;
        this.UpgradeLevel = UpgradeLevel;
        this.UpgradeCounter = UpgradeCounter;
    }

    private Village(string name, TradeGood tradeGood){
        this.Name = name;
        this.Population = 0;
        this.tradeGood = tradeGood;
        this.UpgradeLevel = 0;
        this.UpgradeCounter = 0;
    }

    public static Village InitializeVillage(string name, TradeGood tradeGood)
    {
        return new Village(name, tradeGood);
    }

    public void PayPlayer(Player player, float amount)
    {
        player.IncreaseGold(amount);
    }

    public int CalculatePopTax()
    {
        return (int)(this.Population * 0.1 * ((this.UpgradeLevel * 0.2) + 1));
    }

    public int CalculateResourceIncome()
    {
        return (int) (this.tradeGood != TradeGood.LUMBER ? (int) (this.Population * 0.5 * (int) this.tradeGood) * ((this.UpgradeLevel * 0.2) + 1) : (int) 0);
    }  

    public int CalculateLumberIncome()
    {
        return (int) (this.tradeGood == TradeGood.LUMBER ? (int) (this.Population * 0.3 * ((this.UpgradeLevel * 0.2) + 1)) : (int) 0);
    }      

    public void StartUpgradeVillage()
    {
        this.UpgradeCounter += 3;
    }  

}
