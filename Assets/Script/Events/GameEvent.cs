using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameEvent : MonoBehaviour
{

    public string title;
    public string content;
    public string option1;
    public string option2;
    public string option3;
    public string method1;
    public string method2;
    public string method3;

    public GameEvent(string title, string content, string option1, string option2, string option3, string method1, string method2, string method3){
        this.title = title;
        this.content = content;
        this.option1 = option1;
        this.option2 = option2;
        this.option3 = option3;
        this.method1 = method1;
        this.method2 = method2;
        this.method3 = method3;
        
    }

    // FIRST EVENT
    public void event1method1(){
        Player.Instance.Gold -= 50;
        Player.Instance.Lumber -= 50;
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Event");
        foreach(GameObject currentObject in taggedObjects){
             Destroy(currentObject);
        }
    }
    public void event1method2(){
        Player.Instance.Gold -= 25;
        Player.Instance.Lumber -= 25;
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Event");
        foreach(GameObject currentObject in taggedObjects){
             Destroy(currentObject);
        }
    }
    public void event1method3(){
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Event");
        foreach(GameObject currentObject in taggedObjects){
             Destroy(currentObject);
        }
        Player.Instance.Gold -= 0;
    }

    public static GameEvent InitializeEvent(string title, string content, string option1, string option2, string option3, string method1, string method2, string method3){
        return new GameEvent(title, content, option1, option2, option3, method1, method2, method3);
    }

    
}