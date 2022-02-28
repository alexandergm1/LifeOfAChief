using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Player
{
    public string Name { get; set; }
    public float Gold { get; set; }
    public string Clan { get; set; }
    public int Food { get; set; }
    public int Lumber { get; set; }

    public Player(string name, float gold, string clan, int food, int lumber){
        this.Name = name;
        this.Gold = gold;
        this.Clan = clan;
        this.Food = food;
        this.Lumber = lumber;
    }

    private Player(string name){
        this.Name = name;
        this.Gold = 0;
        this.Clan = "";
        this.Food = 50;
        this.Lumber = 100;

    }

    public static Player InitializePlayer(string name){
        return new Player(name);
    }

    public void IncreaseGold(float amount){
        this.Gold += amount;
    }




    

}
