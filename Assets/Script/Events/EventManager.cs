using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class EventManager : MonoBehaviour
{

    public static event Action TestEventPopup;
    public GameObject endTurnButton = GameObject.Find("EndTurn");


    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == endTurnButton)
        {              
            TestEventPopup?.Invoke();
        }
    }
}