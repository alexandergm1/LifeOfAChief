using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateEvent : MonoBehaviour
{

    [SerializeField] private Transform EventPopup;
    [SerializeField] private Transform panel;
    [SerializeField] private Transform EventLocation;
    public static List<EventList> eventList;
    public GameObject[] options;
    public int currentEvent;

    void Start(){
        EventManager.TestEventPopup += generateEvent;
    }

    void generateEvent(){
        // currentEvent = Random.Range(0, eventList.Count);
        Instantiate(EventPopup, EventLocation.position, Quaternion.identity, panel.transform);
        Text eventTitle = GameObject.Find("Event Title").GetComponent<Text>();
        Text eventText = GameObject.Find("Event Text").GetComponent<Text>();
        Text option1Text = GameObject.Find("Option1 Text").GetComponent<Text>();
        Text option2Text = GameObject.Find("Option2 Text").GetComponent<Text>();
        Text option3Text = GameObject.Find("Option3 Text").GetComponent<Text>();
        eventTitle.text = eventList[currentEvent].title;
        eventText.text = eventList[currentEvent].content;
    }

    void setOptions(){
        for (int i = 0; i < options.Length; i++){
            options[i].transform.GetChild(0).GetComponent<Text>().text = eventList[currentEvent].availableOptions[i];
        }
    }


    public void createEventPopup(){
    }
}