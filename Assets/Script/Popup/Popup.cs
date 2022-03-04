using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{

    GameObject popupWindow = GameObject.Find("PopupBox");

    public void disableWindow(){
        popupWindow.SetActive(false);
    }
}
