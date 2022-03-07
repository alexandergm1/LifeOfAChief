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
        Text villageExpInc = GameObject.Find("Expected Income").GetComponent<Text>();
        Text villageTradeGood = GameObject.Find("TradeGood").GetComponent<Text>();
        Slider villageTax = GameObject.Find("Slider").GetComponent<Slider>();
        villageName.text = selectedVillage.Name + "(lvl " + selectedVillage.UpgradeLevel.ToString() + ")";
        villagePop.text = "Population: " + selectedVillage.Population.ToString();
        string villageExpGold = "<color=#00FF00>" + (selectedVillage.CalculatePopTax() + selectedVillage.CalculateResourceIncome()).ToString() + "</color>";
        string villageExpLumber = "<color=#00FF00>" + selectedVillage.CalculateLumberIncome().ToString() + "</color>";
        villageExpInc.text = "Income: " + villageExpGold + " gold, " + villageExpLumber + " lumber";
        villageTax.value = selectedVillage.Tax;
        villageTradeGood.text = "Producing " + selectedVillage.tradeGood.ToString();
        TaxSlider.village = selectedVillage;
        UpgradeVillage.village = selectedVillage;
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
        Text BuildingSiteTradeGood = GameObject.Find("Trade Good").GetComponent<Text>();
        BuildingSiteName.text = selectedBuildingSite.Name;
        BuildingSiteTradeGood.text = "Trade Good - " + selectedBuildingSite.tradeGood.ToString();
        Colonise.buildingSite = selectedBuildingSite;
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
