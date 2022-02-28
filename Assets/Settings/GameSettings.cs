using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{

    public static Player player;
    public Text Name;
    public Text Lumber;

    void Awake(){
        Name.text = player.Name;
        Lumber.text = player.Lumber.ToString();
    }

    void update()
    {
        
    }
}
