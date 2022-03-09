using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using Random=UnityEngine.Random;


public class EventManager : MonoBehaviour
{

    public static event Action EventPopup;
    public GameObject endTurnButton;

    void Update()
    {
        float value = Random.value;
        if (EventSystem.current.currentSelectedGameObject == endTurnButton && value > 0.4){
                EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
        }
        if(EventSystem.current.currentSelectedGameObject == endTurnButton && value <= 0.4)
        {
            EventPopup?.Invoke();
            EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
        }
    }
}