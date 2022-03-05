using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public static BuildingSite buildingSite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void build()
    {
        Debug.Log("clicked");
        Debug.Log(buildingSite.Name);
        Player.Instance.Build(buildingSite);
    }
}
