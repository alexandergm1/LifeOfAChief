using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleObjectsActive : MonoBehaviour
{
    public GameObject[] villages {get; set;}
    public GameObject[] buildingSites {get; set;}
    public GameObject[] campSites {get; set;}

    void Start()
    {
        villages = GameObject.FindGameObjectsWithTag("Village");
        buildingSites = GameObject.FindGameObjectsWithTag("BuildingSite");
        campSites = GameObject.FindGameObjectsWithTag("CampSite");
    }

    void Update()
    {
        foreach (GameObject village in villages)
        {
            if (Map.Instance.FindVillageByName(village.name) == null)
            {
            village.SetActive(false);
            }
            else village.SetActive(true);
        }

        foreach (GameObject buildingSite in buildingSites)
        {
            if (Map.Instance.FindBuildingSiteByName(buildingSite.name) == null || Map.Instance.FindBuildingSiteByName(buildingSite.name).UnderConstruction == true)
            {
            buildingSite.SetActive(false);
            }
            else buildingSite.SetActive(true);
        }

        foreach (GameObject campSite in campSites)
        {
            string name = "BuildingSite" + campSite.name.Substring(campSite.name.Length-1);
            if (Map.Instance.FindBuildingSiteByName(name) == null) campSite.SetActive(false);
            else if (Map.Instance.FindBuildingSiteByName(name).UnderConstruction == true) campSite.SetActive(true);
            
            
         

        }
    }
}
