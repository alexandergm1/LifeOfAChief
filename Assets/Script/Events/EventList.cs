using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EventList
{

    public string title;
    public string content;
    public string[] availableOptions;

    public EventList(string title, string content, string[] availableOptions){
        this.title = title;
        this.content = content;
        this.availableOptions = availableOptions;
    }

    // FIRST EVENT

    public void Event1Option1(){
        Player.Instance.Gold -= 50;
    }
    public void Event1Option2(){
        Player.Instance.Lumber -= 50;
    }
    public void Event1Option3(){
        Player.Instance.Gold -= 25;
        Player.Instance.Lumber -= 25;
    }



    // public EventList event1 = new EventList("A Storm is Brewing...", "Your villages have been battered by a major storm, will you send them much-needed aid?", );
    
}