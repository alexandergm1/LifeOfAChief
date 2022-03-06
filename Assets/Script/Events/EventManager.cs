// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using System;

// public class EventManager : MonoBehaviour
// {
//     public static EventManager current;
    
//     private void Start(){
//         current = this;
//     }


//     public event Action TestEventPopup;



//     void Update()
//     {
//         if (Input.GetMouseButtonDown(0))
//         {
//             RaycastHit hit = new RaycastHit();        
//             Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
    
//             if (Physics.Raycast(ray, out hit))
//             {
//                 if (hit.collider.gameObject.tag == "EndTurn"){
                
//                 TestEventPopup?.Invoke();

//                 }
//             }
//         }
//     }
// }