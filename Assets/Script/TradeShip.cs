using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeShip : MonoBehaviour
{
    
    public bool docked { get; set; }
    public static TradeShip Instance { get; set; }

    public TradeShip(){
        this.docked = true;
    }

    public static TradeShip InitializeTradeShip()
    {
        Instance = new TradeShip();
        return Instance;
    }

    public void TradeLumber(Player player, int lumber)
    {
        if(player.Lumber >= lumber)
        {
        player.Lumber -= lumber;
        player.Gold += lumber * 4;
        }
    }

    public int CalculateLumberValue(int lumber)
    {
        return lumber * 4;
    }

}
