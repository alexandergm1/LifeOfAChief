using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VillageOnClick : MonoBehaviour
{
    [SerializeField] private Transform PopupWindowVillage;
    [SerializeField] private Transform panel;
    public Village selectedVillage;

void OnMouseDown()
    {
        Instantiate(PopupWindowVillage, Vector3.zero, Quaternion.identity, panel.transform);
        Village selectedVillage = Map.Instance.FindVillageByName(this.gameObject.name);
        Debug.Log(Map.Instance.FindVillageByName(this.gameObject.name).Name);
        Text villageName = GameObject.Find("EntityName").GetComponent<Text>();
        Text villagePop = GameObject.Find("Population").GetComponent<Text>();
        Text villageLevel = GameObject.Find("Upgrade Level").GetComponent<Text>();
        villageName.text = selectedVillage.Name;
        villagePop.text = selectedVillage.Population.ToString();
        villageLevel.text = selectedVillage.UpgradeLevel.ToString();
    }


    void Update()
    {
        if (Map.Instance.FindVillageByName(this.gameObject.name) == null)
        {
        this.gameObject.SetActive(false);
        }
    }
}
