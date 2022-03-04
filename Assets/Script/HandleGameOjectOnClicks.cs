using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleGameOjectOnClicks : MonoBehaviour
{
    void OnMouseDown()
    {
        RaycastHit hit = new RaycastHit();        
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
        if (Physics.Raycast(ray, out hit))
        {
                 
 
            if (hit.collider.gameObject.name.Substring(0, 7) == "Village")
            {
                Debug.Log("Click!!!");
            }
            else
            {
                Debug.Log("Click outside");
                   
            }
        }
    }
}
