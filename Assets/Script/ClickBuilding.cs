using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    public Castle castle;
    public static Player player;
    void Start()
    {
        castle = Castle.InitializeCastle("Edin Castle");
    }

    void OnMouseDown(){
        Debug.Log("Object was clicked");
        castle.PayPlayer(player, 10F);
        Debug.Log(player.Gold);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
