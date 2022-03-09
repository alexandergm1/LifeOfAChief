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
            myAnimationController.SetBool("Sailing", true);
            myAnimationController.SetBool("Docked", false);
        }
        else if (TradeShip.Instance.docked == true)
        {
            myAnimationController.SetBool("Sailing", false);
            myAnimationController.SetBool("Docked", true);
        }
    }
}
