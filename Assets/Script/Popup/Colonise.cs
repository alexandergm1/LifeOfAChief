using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colonise : MonoBehaviour
{
    public Text coloniseBtn;
    public static BuildingSite buildingSite;

    void Start()
    {

    }

    void Update()
    {
        Text coloniseBtn = GameObject.Find("Colonise").GetComponentInChildren<Text>();
        if (buildingSite.UnderConstruction == false) coloniseBtn.text ="<color=#FF0000>-" + buildingSite.GoldCost.ToString() + "</color>" + " Gold\n" + "<color=#FF0000>-" + buildingSite.LumberCost.ToString() + "</color>" + " Lumber";
        else coloniseBtn.text = buildingSite.BuildTime.ToString() + " Weeks remaining";

    }

    public void build()
    {
        if (buildingSite.UnderConstruction == false) Player.Instance.Build(buildingSite);  
    }


}
