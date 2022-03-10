using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class GameSettings : MonoBehaviour
{

    public static string playerNameStr;
    public Text Name;
    public Text Lumber;
    public Text Gold;
    public Text Week;
    public DateTime StartDate = new DateTime (1322, 3, 10);
    public static Player player { get; set;}
    public static GameState gameState { get; set;}
    public static Map map { get; set;}
    public static GameEventList eventList { get; set;}
    public static TradeShip tradeShip { get; set;}

    void Start(){
        map = Map.InitializeMap();
        eventList = GameEventList.InitializeEventList();
        player = Player.InitializePlayer(playerNameStr);
        player.TakeControlOfVillageFromMap(map, "Kilmuir");
        player.TakeControlOfVillageFromMap(map, "Milovaig");
        player.TakeControlOfVillageFromMap(map, "Waternish");
        player.TakeControlOfCastleFromMap(map, "Dunvegan");
        TradeShip.InitializeTradeShip();
        gameState = GameState.InitializeGameState(player, map);
        ClickBuilding.player = player;
        Name.text = player.Name.ToString();
    }

    public void MainEndTurn(){
        gameState.EndTurn();
    }

    void Update()
    {
        Week.text = StartDate.AddDays(gameState.Turn * 7).ToShortDateString();
        Gold.text = player.Gold.ToString();
        Lumber.text = player.Lumber.ToString();
    }
}
