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

    void Start(){
        player = Player.InitializePlayer(playerNameStr);
        ClickBuilding.player = player;
        GameState.player = player;
    }

    void Update()
    {
        Name.text = player.Name.ToString();
        Gold.text = player.Gold.ToString();
        Lumber.text = player.Lumber.ToString();

    }
}
