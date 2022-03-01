using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    void Awake() {
    }

    // Update is called once per frame

    public void loadGame(){
        SceneManager.LoadScene("GameMap");
    }
}
