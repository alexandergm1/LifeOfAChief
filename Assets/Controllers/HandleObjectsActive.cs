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
        foreach (GameObject village in villages)
        {
            foreach (Transform child in village.transform.GetChild(0).gameObject.transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }

    void Update()
    {
        foreach (GameObject village in villages)
        { 
            if (Map.Instance.FindVillageByName(village.name) != null)
            {
                village.SetActive(true);
                int upgradeLevel = Map.Instance.FindVillageByName(village.name).UpgradeLevel;
                int n = upgradeLevel;
                while (n > 0)
                {
                    village.transform.GetChild(0).gameObject.transform.GetChild(n - 1).gameObject.SetActive(true);
                    n -= 1;
                }
            }
            else village.SetActive(false);
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
            campSite.SetActive(false);
            if (Map.Instance.FindBuildingSiteByName(name) == null) campSite.SetActive(false);
            else if (Map.Instance.FindBuildingSiteByName(name).UnderConstruction == true) campSite.SetActive(true);
        }
    }
}
