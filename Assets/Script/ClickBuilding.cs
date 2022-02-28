using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    public Castle castle;
    string testName;
    void Start()
    {
        testName = "Hi i am a Test";
        GameObject CastleObject = GameObject.Find("Tower_a");


       
        
        Player player = Player.InitializePlayer("Patrick");
        Castle castle = Castle.InitializeCastle("Edin Castle");
    }

    void OnMouseDown(){
        Debug.Log("Object was clicked");
        // castle.PayPlayer(player, 10F);
        Debug.Log(player.Gold);
        Debug.Log(testName);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
