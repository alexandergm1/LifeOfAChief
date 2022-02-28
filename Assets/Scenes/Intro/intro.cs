using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    public static string playerNameStr;

    public Text playerName;
    public Text lumber;
    Player player;


    void Awake() {
        player = Player.InitializePlayer(playerNameStr);
    }

    // Update is called once per frame

    public void loadGame(){
        GameSettings.player = player;
        SceneManager.LoadScene("GameMap");
    }
}
