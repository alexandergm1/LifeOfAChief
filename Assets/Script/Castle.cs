using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    void onMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
  {
  	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
   	RaycastHit hit;
   	// Casts the ray and get the first game object hit
   	Physics.Raycast(ray, out hit);
   	Debug.Log("This hit at " + hit.point );
  }
    }

}
