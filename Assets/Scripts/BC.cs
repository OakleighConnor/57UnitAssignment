using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BC : MonoBehaviour
{
    ButtonUI buttonUI;

    private void Start()
    {
    }
    public void ButtonControlCaller()
    {
        buttonUI = GameObject.FindWithTag("ButtonManSingle").GetComponent<ButtonUI>();
        buttonUI.ChangeSceneButton();
    }
}
