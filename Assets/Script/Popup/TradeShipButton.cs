using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradeShipButton : MonoBehaviour
{
   public Text TradeBtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TradeShip.Instance.docked == false) GameObject.Find("Trade").SetActive(false);
        else if (TradeShip.Instance.docked == true) 
        {
            Text TradeBtn = GameObject.Find("Trade").GetComponentInChildren<Text>();
            TradeBtn.text = "100 Lumber = 400 Gold!";  
        }
    }

    public void Trade()
    {
        if (Player.Instance.Lumber >= 100)
        {
            TradeShip.Instance.TradeLumber(Player.Instance, 100); 
            TradeShip.Instance.docked = false;
        } 
    }
}
