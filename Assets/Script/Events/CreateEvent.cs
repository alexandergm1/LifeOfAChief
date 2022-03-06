// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class CreateEvent : MonoBehaviour
// {

//     void Start(){
//         EventManager.TestEventPopup += createEventPopup;
//     }

//     [SerializeField] private Transform EventPopup;
//     [SerializeField] private Transform panel;
//     private string testString = "This is the example event title";
//     private string testString2 = "This is the example event text";

//     public void createEventPopup(){
//         Instantiate(EventPopup, Vector3.zero, Quaternion.identity, panel.transform);
//         Text eventTitle = GameObject.Find("Event Title").GetComponent<Text>();
//         Text eventText = GameObject.Find("Event Text").GetComponent<Text>();
//         eventTitle.text = testString;
//         eventText.text = testString2;
//     }
// }
