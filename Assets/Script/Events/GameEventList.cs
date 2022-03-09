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
        eventList.AddGameEvent(GameEvent.InitializeEvent("Viking Raid!", "Norsemen from the Lordship of the Isles have landed on our shores! How will we deal with them?", "We will fight them with our castle garrison! (-100 soldiers)", "Pay them to leave us alone. (-100 Gold)", "The villages can fend for themselves... (-150 population in a village)", "event2method1", "event2method2", "event2method3"));
        eventList.AddGameEvent(GameEvent.InitializeEvent("Bountiful Harvest", "Chief! The farmers report that there has this has been a great year for harvesting. What should we do with the surplus?", "Sell the surplus for some extra gold. (+200 Gold)", "Hire some more soldiers for the castle garrison. (+150 soldiers)", "Invest the resources back into the villages! (+100 population in all villages)", "event3method1", "event3method2", "event3method3"));
        eventList.AddGameEvent(GameEvent.InitializeEvent("Distant Relatives come Ashore", "A ship has arrived at our port with our standard on its sails! They are MacLeods of Lewis, our kinsmen. They offer gold in exchange for lumber to buildnew ships and a crew to sail them.", "Accept the offer, they are family! (+100 Gold, -50 Lumber, -50 population in a village)", "Refuse the offer, we need the people and lumber. (No effect)", "I always hated that side of the family. Kill them all. (+200 Gold, -25 soldiers)", "event4method1", "event4method2", "event4method3"));

        Instance = eventList;
        return Instance;
    }





}