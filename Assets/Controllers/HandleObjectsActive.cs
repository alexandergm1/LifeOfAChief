using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleObjectsActive : MonoBehaviour
{
    public GameObject[] villages {get; set;}
    public GameObject[] buildingSites {get; set;}

    void Start()
    {
        villages = GameObject.FindGameObjectsWithTag("Village");
        buildingSites = GameObject.FindGameObjectsWithTag("BuildingSite");
    }

    void Update()
    {
        foreach (GameObject village in villages)
        if (Map.Instance.FindVillageByName(village.name) == null)
        {
        village.SetActive(false);
        }
        else village.SetActive(true);

        foreach (GameObject buildingSite in buildingSites)
        if (Map.Instance.FindBuildingSiteByName(buildingSite.name) == null)
        {
        buildingSite.SetActive(false);
        }
        else buildingSite.SetActive(true);
    }
}
