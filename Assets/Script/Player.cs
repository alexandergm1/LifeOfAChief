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
    public List<Castle> castles { get; set; }

    public Player(string name, float gold, string clan, int food, int lumber)
    {
        this.Name = name;
        this.Gold = gold;
        this.Clan = clan;
        this.Food = food;
        this.Lumber = lumber;
        this.villages = new List<Village>();
        this.castles = new List<Castle>();
    }

    private Player(string name)
    {
        this.Name = name;
        this.Gold = 300;
        this.Clan = "";
        this.Food = 300;
        this.Lumber = 100;
        this.villages = new List<Village>();
        this.castles = new List<Castle>();

    }

    public static Player InitializePlayer(string name)
    {
        Player player = new Player(name);
        player.AddVillage(Village.InitializeVillage1());
        player.AddVillage(Village.InitializeVillage2());
        player.AddVillage(Village.InitializeVillage3());
        player.AddCastle(Castle.InitializeStartingCastle());
        return player;
    }

    public void IncreaseGold(float amount)
    {
        this.Gold += amount;
    }

    public void AddVillage(Village village)
    {
        this.villages.Add(village);
    }

    public void AddCastle(Castle castle)
    {
        this.castles.Add(castle);
    }

    public void CollectTotalIncome()
    {
        this.CollectTaxIncome();
        this.CollectResourceIncome();
        this.CollectLumberIncome();
        this.CollectCastleIncome();
    }

    public void CollectTaxIncome()
    {
        foreach (Village village in this.villages)
        {
            this.Gold += village.CalculatePopTax();
        }
    }

    public void CollectResourceIncome()
    {
        foreach (Village village in this.villages)
        {
            this.Gold += village.CalculateResourceIncome();
        }
    }

    public void CollectLumberIncome()
    {
        foreach (Village village in this.villages)
        {
            this.Lumber += village.CalculateLumberIncome();
        }
    }

    public void CollectCastleIncome()
    {
        foreach (Castle castle in this.castles)
        {
            this.Gold += castle.CalculateCastleIncome();
        }
    }
}
