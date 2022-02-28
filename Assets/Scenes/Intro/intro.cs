using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intro : MonoBehaviour
{
    public static string playerNameStr;

    public Text playerName;
    public Text lumber;
    Player player;


    void Awake() {
        player = Player.InitializePlayer(playerNameStr);
        playerName.text = player.Name;
        lumber.text = player.Lumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
