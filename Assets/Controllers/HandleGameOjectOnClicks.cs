using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleGameOjectOnClicks : MonoBehaviour
{

    [SerializeField] private Transform PopupWindowVillage;
    [SerializeField] private Transform panel;
    public Village selectedVillage;

    void createVillage(){
        Instantiate(PopupWindowVillage, Vector3.zero, Quaternion.identity, panel.transform);
        Text villageName = GameObject.Find("EntityName").GetComponent<Text>();
        Text villagePop = GameObject.Find("Population").GetComponent<Text>();
        Text villageLevel = GameObject.Find("Upgrade Level").GetComponent<Text>();
        villageName.text = selectedVillage.Name;
        villagePop.text = selectedVillage.Population.ToString();
        villageLevel.text = selectedVillage.UpgradeLevel.ToString();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
    {
        RaycastHit hit = new RaycastHit();        
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
        if (Physics.Raycast(ray, out hit))
        {
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Popup");
            foreach(GameObject currentObject in taggedObjects){
                Destroy(currentObject);
            }
                 
 
            if (hit.collider.gameObject.tag == "Village")
            {
                selectedVillage = Map.Instance.FindVillageByName(hit.collider.gameObject.name);
                Invoke("createVillage", 0.001f);
            }

            else if (hit.collider.gameObject.tag == "Castle")
            {
                Debug.Log("Clicked on Castle");
            }
            else if (hit.collider.gameObject.tag == "BuildingSite")
            {
                Debug.Log("Clicked on BuildingSite");
            }
            else
            {
                Debug.Log("Click outside");
                   
            }
        }
    }
}
}
