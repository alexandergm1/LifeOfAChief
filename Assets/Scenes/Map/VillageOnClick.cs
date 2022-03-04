using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageOnClick : MonoBehaviour
{
    [SerializeField] private Transform PopupWindowVillage;
    [SerializeField] private Transform panel;
    public Village selectedVillage;
    
    void OnMouseDown()
    {
        Instantiate(PopupWindowVillage, Vector3.zero, Quaternion.identity, panel.transform);
        Village selectedVillage = Map.Instance.FindVillageByName(this.gameObject.name);
        Text villageName = GameObject.Find("EntityName").GetComponent<Text>();
        villageName.text = selectedVillage.Name;
    }


    void Update()
    {
        if (Map.Instance.FindVillageByName(this.gameObject.name) == null)
        {
        this.gameObject.SetActive(false);
        }
    }
}
