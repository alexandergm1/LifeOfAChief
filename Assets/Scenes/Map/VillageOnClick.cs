using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageOnClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log(Map.Instance.FindVillageByName(this.gameObject.name).Name);
    }

    void Start()
    {

    }


    void Update()
    {
        if (Map.Instance.FindVillageByName(this.gameObject.name) == null)
        {
        this.gameObject.SetActive(false);
        }
    }
}
