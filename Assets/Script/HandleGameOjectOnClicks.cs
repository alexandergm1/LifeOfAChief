using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleGameOjectOnClicks : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
    {
        RaycastHit hit = new RaycastHit();        
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
        if (Physics.Raycast(ray, out hit))
        {
                 
 
            if (hit.collider.gameObject.tag == "Village")
            {
                Debug.Log("Clicked on Village");
            }
            else if (hit.collider.gameObject.tag == "Castle")
            {
                Debug.Log("Clicked on Castle");
            }
            else if (hit.collider.gameObject.tag == "BuildingSite")
            {
                Debug.Log("Clicked on BuildingSite");
            }
            else
            {
                Debug.Log("Click outside");
                   
            }
        }
    }
}
}
