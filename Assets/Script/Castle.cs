using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle
{
    
    public string Name { get; set; }
    public int Population { get; set; }
    public int Soldiers { get; set; }

    public Castle(string name, int population, int soldiers){
        this.Name = name;
        this.Population = population;
        this.Soldiers = soldiers;
    }

    private Castle(string name){
        this.Name = name;
        this.Population = 0;
        this.Soldiers = 0;
    }

    public static Castle InitializeCastle(string name)
    {
        return new Castle(name);
    }

    public void PayPlayer(Player player, float amount)
    {
        player.IncreaseGold(amount);
    }

    public static Castle InitializeStartingCastle()
    {
        Castle startCastle = new Castle("Tower_a");
        startCastle.Population = 2000;
        startCastle.Soldiers = 200;
        return startCastle;
    }

    public int CalculateCastleIncome()
    {
        return (int) ((double) this.Population * 0.1);
    }
}
