using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public float movementSpeed;
    public float movementTime;
    public Vector3 newPosition;

    void Start(){
        newPosition = transform.position;
    }

    void Update(){
        handleMovementInput();
    }

    void handleMovementInput(){

        if (Input.GetKey(KeyCode.W)){
            newPosition += (transform.forward * movementSpeed);
        }
        if (Input.GetKey(KeyCode.S)){
            newPosition += (transform.forward * -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D)){
            newPosition += (transform.right * movementSpeed);
        }
        if (Input.GetKey(KeyCode.A)){
            newPosition += (transform.right * -movementSpeed);
        }

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementTime);
    }

}
