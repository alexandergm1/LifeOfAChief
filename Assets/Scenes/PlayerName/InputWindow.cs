using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InputWindow : MonoBehaviour
{

    public InputField playerName;

    public void submit(){
        Debug.Log("Player Name is:" + playerName.text);
        GameSettings.playerNameStr = playerName.text;
        SceneManager.LoadScene("Intro");
    }
}