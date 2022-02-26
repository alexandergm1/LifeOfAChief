using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentMusic : MonoBehaviour
{

    public static PersistentMusic instance;

    private void Awake(){
        DontDestroyOnLoad(transform.gameObject);

        if (instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
}
