using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameEventList : MonoBehaviour
{

    public List<GameEvent> events;
    public static GameEventList Instance { get; private set;}


    public GameEventList()
    {
        this.events = new List<GameEvent>();
    }

    public void AddGameEvent(GameEvent gameEvent){
        this.events.Add(gameEvent);
    }

    public static GameEventList InitializeEventList(){
        GameEventList eventList = new GameEventList();
        eventList.AddGameEvent(GameEvent.InitializeEvent("A Storm is Brewing...", "Your villages have been battered by a storm, will you send them much-needed aid?", "Send all the help that we can! (-50 Gold, -50 Lumber)", "Only send what is needed most. (-25 Gold, -25 Lumber)", "It's not my fault they chose to live near the sea! (No effect)", "event1method1", "event1method2", "event1method3"));


        Instance = eventList;
        return Instance;
    }





}