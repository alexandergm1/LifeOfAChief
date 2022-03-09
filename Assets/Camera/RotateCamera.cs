using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    public float Speed = 5;
    
    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            transform.eulerAngles += Speed * new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        }
    }
}
