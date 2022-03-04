using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupTest : MonoBehaviour
{
    [SerializeField] private Transform PopupWindowVillage;
    [SerializeField] private Transform panel;

    void Start(){
       Instantiate(PopupWindowVillage, Vector3.zero, Quaternion.identity, panel.transform);
   }
}