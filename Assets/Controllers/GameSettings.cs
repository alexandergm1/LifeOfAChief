using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{

    public static string playerNameStr;
    public Text Name;
    public Text Lumber;
    public Text Gold;
    public static Player player { get; set;}
    public static GameState gameState { get; set;}
    public static Map map { get; set;}

    void Start(){
        map = Map.InitializeMap();
        player = Player.InitializePlayer(playerNameStr);
        player.TakeControlOfVillageFromMap(map, "Village1");
        player.TakeControlOfVillageFromMap(map, "Village2");
        player.TakeControlOfVillageFromMap(map, "Village3");
        player.TakeControlOfCastleFromMap(map, "Dunvegan");
        gameState = GameState.InitializeGameState(player, map);
        ClickBuilding.player = player;
        Name.text = player.Name.ToString();
    }

    public void MainEndTurn(){
        gameState.EndTurn();
        if (map.BuildingSites[0].UnderConstruction == false) player.Build(map.BuildingSites[0]);
        // Debug.Log(map.Villages.Count);
        // Debug.Log(map.BuildingSites.Count);
        Debug.Log(map.Villages[map.Villages.Count - 1].Name);
    }

    void Update()
    {
        Gold.text = player.Gold.ToString();
        Lumber.text = player.Lumber.ToString();
    }
}
