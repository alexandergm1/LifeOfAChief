using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InputWindow : MonoBehaviour
{

    public InputField playerName;

    public void submit(){
        GameSettings.playerNameStr = playerName.text;
        SceneManager.LoadScene("GameMap");
    }
}