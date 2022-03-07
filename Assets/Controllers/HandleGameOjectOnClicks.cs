using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using TMPro;

public class HandleGameOjectOnClicks : MonoBehaviour
{

    [SerializeField] private Transform PopupWindowVillage;
    [SerializeField] private Transform PopupWindowCastle;
    [SerializeField] private Transform PopupWindowBuildingSite;
    [SerializeField] private Transform panel;
    public Village selectedVillage;
    public Castle selectedCastle;
    public BuildingSite selectedBuildingSite;

    void createVillage(){
        Instantiate(PopupWindowVillage, Vector3.zero, Quaternion.identity, panel.transform);
        Text villageName = GameObject.Find("EntityName").GetComponent<Text>();
        Text villagePop = GameObject.Find("Population").GetComponent<Text>();
        Text villageLevel = GameObject.Find("Upgrade Level").GetComponent<Text>();
        Slider villageTax = GameObject.Find("Slider").GetComponent<Slider>();
        villageName.text = selectedVillage.Name;
        villagePop.text = selectedVillage.Population.ToString();
        villageLevel.text = selectedVillage.UpgradeLevel.ToString();
        villageTax.value = selectedVillage.Tax;
        TaxSlider.village = selectedVillage;
        // selectedVillage.Tax = Int32.Parse(villageTax.text);
    }
    void createCastle(){
        Instantiate(PopupWindowCastle, Vector3.zero, Quaternion.identity, panel.transform);
        Text castleName = GameObject.Find("EntityName").GetComponent<Text>();
        Text castlePop = GameObject.Find("Population").GetComponent<Text>();
        Text castleSoldiers = GameObject.Find("Soldiers").GetComponent<Text>();
        castleName.text = selectedCastle.Name;
        castlePop.text = selectedCastle.Population.ToString();
        castleSoldiers.text = selectedCastle.Soldiers.ToString();
    }

    void createBuildingSite(){
        Instantiate(PopupWindowBuildingSite, Vector3.zero, Quaternion.identity, panel.transform);
        Text BuildingSiteName = GameObject.Find("EntityName").GetComponent<Text>();
        Text BuildingSitePop = GameObject.Find("Population").GetComponent<Text>();
        Text BuildingSiteGoldCost = GameObject.Find("Gold Cost").GetComponent<Text>();
        Text BuildingSiteLumberCost = GameObject.Find("Lumber Cost").GetComponent<Text>();
        BuildingSiteName.text = selectedBuildingSite.Name;
        BuildingSitePop.text = selectedBuildingSite.Population.ToString();
        BuildingSiteGoldCost.text = selectedBuildingSite.GoldCost.ToString();
        BuildingSiteLumberCost.text = selectedBuildingSite.LumberCost.ToString();
        PlayerActions.buildingSite = selectedBuildingSite;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
    {
        RaycastHit hit = new RaycastHit();        
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
        if (Physics.Raycast(ray, out hit))
        {
                if (EventSystem.current.currentSelectedGameObject == null)
                {
                        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Popup");
                        foreach(GameObject currentObject in taggedObjects)
                        {
                            Destroy(currentObject);
                        }
                }   
                    
            if (hit.collider.gameObject.tag == "Village")
            {
                selectedVillage = Map.Instance.FindVillageByName(hit.collider.gameObject.name);
                Invoke("createVillage", 0.001f);
            }

            else if (hit.collider.gameObject.tag == "Castle")
            {
                selectedCastle = Map.Instance.FindCastleByName(hit.collider.gameObject.name);
                Invoke("createCastle", 0.001f);
            }
            else if (hit.collider.gameObject.tag == "BuildingSite")
            {
                selectedBuildingSite = Map.Instance.FindBuildingSiteByName(hit.collider.gameObject.name);
                Debug.Log(hit.collider.gameObject.name);
                Invoke("createBuildingSite", 0.001f);
            }
            else
            {
                Debug.Log("Click outside");
                   
            }
        }
    }
}
}
