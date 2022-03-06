using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventList
{

    public void Event1Option1(){
        Player.instance.Gold -= 50;
    }
    public void Event1Option2(){
        Player.instance.Lumber -= 50;
    }
    public void Event1Option3(){
        Player.instance.Gold -= 25;
        Player.instance.Lumber -= 25;
    }













}
