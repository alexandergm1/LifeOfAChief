using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string Name { get; set; }
    public float Gold { get; set; }
    public string Clan { get; set; }
    public int Food { get; set; }
    public int Lumber { get; set; }
    public List<Village> villages { get; set; }

    public Player(string name, float gold, string clan, int food, int lumber){
        this.Name = name;
        this.Gold = gold;
        this.Clan = clan;
        this.Food = food;
        this.Lumber = lumber;
        this.villages = new List<Village>();
    }

    private Player(string name){
        this.Name = name;
        this.Gold = 0;
        this.Clan = "";
        this.Food = 50;
        this.Lumber = 100;
        this.villages = new List<Village>();

    }

    public static Player InitializePlayer(string name){
        return new Player(name);
    }

    public void IncreaseGold(float amount){
        this.Gold += amount;
    }

    public void AddVillage(Village village){
        this.villages.Add(village);
    }

    public void CollectIncome(){
        foreach (Village village in this.villages){
            this.Gold += village.CalculatePopTax();
        }
        
    }




    

}
