using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeShipAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    void Update()
    {
        if (TradeShip.Instance.docked == false)
        {
            myAnimationController.SetBool("ShipSailing", true);
            myAnimationController.SetBool("Docked", false);
        }
        else 
        {
            myAnimationController.SetBool("ShipSailing", false);
            myAnimationController.SetBool("Docked", true);
        }
    }
}
