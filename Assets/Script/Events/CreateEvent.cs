using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;




public class CreateEvent : MonoBehaviour
{

    [SerializeField] private Transform EventPopup;
    [SerializeField] private Transform panel;
    [SerializeField] private Transform EventLocation;


    void Start(){
        EventManager.EventPopup += generateEvent;
        
    }

    void generateEvent(){
        int currentEvent = Random.Range (0, GameEventList.Instance.events.Count);
        Instantiate(EventPopup, EventLocation.position, Quaternion.identity, panel.transform);
        Text eventTitle = GameObject.Find("Event Title").GetComponent<Text>();
        Text eventText = GameObject.Find("Event Text").GetComponent<Text>();
        Text option1Text = GameObject.Find("Option1 Text").GetComponent<Text>();
        Text option2Text = GameObject.Find("Option2 Text").GetComponent<Text>();
        Text option3Text = GameObject.Find("Option3 Text").GetComponent<Text>();
        Button Option1 = GameObject.Find("Option1").GetComponent<Button>();
		Option1.onClick.AddListener(() => callMethod(GameEventList.Instance.events[currentEvent].method1));
        Button Option2 = GameObject.Find("Option2").GetComponent<Button>();
		Option2.onClick.AddListener(() => callMethod(GameEventList.Instance.events[currentEvent].method2));
        Button Option3 = GameObject.Find("Option3").GetComponent<Button>();
		Option3.onClick.AddListener(() => callMethod(GameEventList.Instance.events[currentEvent].method3));

        eventTitle.text = GameEventList.Instance.events[currentEvent].title;
        eventText.text = GameEventList.Instance.events[currentEvent].content;
        option1Text.text = GameEventList.Instance.events[currentEvent].option1;
        option2Text.text = GameEventList.Instance.events[currentEvent].option2;
        option3Text.text = GameEventList.Instance.events[currentEvent].option3;
    }

    public void event1method1(){
        Player.Instance.Gold -= 50;
        Player.Instance.Lumber -= 50;
    }
    public void event1method2(){
        Player.Instance.Gold -= 25;
        Player.Instance.Lumber -= 25;
    }
    public void event1method3(){
        Player.Instance.Gold -= 0;
    }
    public void event2method1(){
        Player.Instance.castles[0].Soldiers -= 100;
    }
    public void event2method2(){
        Player.Instance.Gold -= 100;
    }
    public void event2method3(){
        Player.Instance.villages[0].Population -= 150;
    }
    public void event3method1(){
        Player.Instance.Gold += 200;
    }
    public void event3method2(){
        Player.Instance.castles[0].Soldiers += 100;
    }
    public void event3method3(){
        foreach(Village village in Player.Instance.villages){
            village.Population += 100;
        }
    }
    public void event4method1(){
        Player.Instance.Gold += 100;
        Player.Instance.Lumber -= 50;
        Player.Instance.villages[2].Population -= 50;
    }
    public void event4method2(){
        
    }
    public void event4method3(){
        Player.Instance.castles[0].Soldiers -= 25;
        Player.Instance.Gold += 200;
    }
    


    public void callMethod(string methodName){
        Invoke(methodName, 0.001f);
    }

}