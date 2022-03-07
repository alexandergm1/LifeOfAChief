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

    void generateEvent(){
        GameEvent currentEvent = GameEventList.Instance.events[0];
        Instantiate(EventPopup, EventLocation.position, Quaternion.identity, panel.transform);
        Text eventTitle = GameObject.Find("Event Title").GetComponent<Text>();
        Text eventText = GameObject.Find("Event Text").GetComponent<Text>();
        Text option1Text = GameObject.Find("Option1 Text").GetComponent<Text>();
        Text option2Text = GameObject.Find("Option2 Text").GetComponent<Text>();
        Text option3Text = GameObject.Find("Option3 Text").GetComponent<Text>();
        eventTitle.text = currentEvent.title;
        eventText.text = currentEvent.content;
        option1Text.text = currentEvent.option1;
        option2Text.text = currentEvent.option2;
        option3Text.text = currentEvent.option2;
    }

}