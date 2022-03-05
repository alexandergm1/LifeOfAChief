using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleObjectsActive : MonoBehaviour
{
    public GameObject[] villages {get; set;}

    void Start()
    {
        villages = GameObject.FindGameObjectsWithTag("Village");
    }

    void Update()
    {
        foreach (GameObject village in villages)
        if (Map.Instance.FindVillageByName(village.name) == null)
        {
        village.SetActive(false);
        }
        else village.SetActive(true);
    }
}
