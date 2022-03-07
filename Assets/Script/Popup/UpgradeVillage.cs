using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeVillage : MonoBehaviour
{
    public Text upgradeBtn;
    public static Village village;

    void Start()
    {

    }

    void Update()
    {
        Text upgradeBtn = GameObject.Find("Upgrade").GetComponentInChildren<Text>();
        int upgradeCost = (village.UpgradeLevel * 500) + 400;
        if (village.UpgradeCounter == 0) upgradeBtn.text = "Upgrade\n" + "<color=#FF0000>-" + upgradeCost.ToString() + "</color>" + " Gold";
        else upgradeBtn.text = village.UpgradeCounter.ToString() + " Weeks remaining";

    }
   
    public void Upgrade()
    {
        Player.Instance.UpgradeVillage(village);
    }


}
