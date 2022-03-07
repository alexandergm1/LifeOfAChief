using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleGameOjectOnClicks : MonoBehaviour
{

    [SerializeField] private Transform PopupWindowVillage;
    [SerializeField] private Transform PopupWindowCastle;
    [SerializeField] private Transform panel;
    public Village selectedVillage;
    public Castle selectedCastle;

    void createVillage(){
        Instantiate(PopupWindowVillage, Vector3.zero, Quaternion.identity, panel.transform);
        Text villageName = GameObject.Find("EntityName").GetComponent<Text>();
        Text villagePop = GameObject.Find("Population").GetComponent<Text>();
        Text villageLevel = GameObject.Find("Upgrade Level").GetComponent<Text>();
        villageName.text = selectedVillage.Name;
        villagePop.text = selectedVillage.Population.ToString();
        villageLevel.text = selectedVillage.UpgradeLevel.ToString();
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

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
    {
        RaycastHit hit = new RaycastHit();        
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
        if (Physics.Raycast(ray, out hit))
        {
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Event");
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
                selectedCastle = Map.Instance.FindCastleByName(hit.collider.gameObject.name);
                Debug.Log(hit.collider.gameObject.name);
                Invoke("createCastle", 0.001f);
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
