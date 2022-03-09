using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{
    public Animator animator;
    public Button _button;

    void Start()
    {
        _button = GameObject.Find("EndTurn").GetComponent<Button>();
        _button.onClick.AddListener(() => FadeOut());
    }

    void FadeOut()
    {
        _button.onClick.AddListener(() => animator.SetTrigger("FadeOut"));
    }

}
