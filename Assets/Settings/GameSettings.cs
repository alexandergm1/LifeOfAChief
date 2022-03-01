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
    public static Player player;
    public static GameState gameState;

    void Start(){
        player = Player.InitializePlayer(playerNameStr);
        gameState = GameState.InitializeGameState(player);
        ClickBuilding.player = player;
    }

    public void MainEndTurn(){
        gameState.EndTurn();
    }

    void Update()
    {
        Name.text = player.Name.ToString();
        Gold.text = player.Gold.ToString();
        Lumber.text = player.Lumber.ToString();
    }
}
