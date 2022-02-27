using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string Name { get; set; }
    float Gold { get; set; }
    string Clan { get; set; }
    int Food { get; set; }
    int Lumber { get; set; }

    public Player(string Name, float Gold, string Clan, int Food, int Lumber){
        this.Name = Name;
        this.Gold = Gold;
        this.Clan = Clan;
        this.Food = Food;
        this.Lumber = Lumber;
    }


    

}
