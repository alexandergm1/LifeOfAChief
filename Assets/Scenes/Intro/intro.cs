using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intro : MonoBehaviour
{
    public static string playerNameStr;

    public Text playerName;

    void Awake() {
        playerName.text = playerNameStr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
