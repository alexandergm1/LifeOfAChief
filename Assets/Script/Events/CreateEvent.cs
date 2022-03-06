using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateEvent : MonoBehaviour
{

    [SerializeField] private Transform EventPopup;
    [SerializeField] private Transform panel;
    [SerializeField] private Transform EventLocation;

    void Start(){
        EventManager.TestEventPopup += generateEvent;
    }


    public List<EventList> eventList;
    public GameObject[] options;
    public int currentEvent;

    void generateEvent(){
        currentEvent = Random.Range(0, eventList.Count);
        Instantiate(EventPopup, EventLocation.position, Quaternion.identity, panel.transform);
        Text eventTitle = GameObject.Find("Event Title").GetComponent<Text>();
        Text eventText = GameObject.Find("Event Text").GetComponent<Text>();
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