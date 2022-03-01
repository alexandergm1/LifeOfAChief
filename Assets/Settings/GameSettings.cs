using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{

    public static Player player;
    public static Text Name;
    public Text Lumber;
    public Text Gold;

    void Awake(){
        Name.text = player.Name;
        Lumber.text = player.Lumber.ToString();
        Gold.text = player.Gold.ToString();
    }

    void update()
    {
        Lumber.text = player.Lumber.ToString();
        Gold.text = player.Gold.ToString();
    }
}
