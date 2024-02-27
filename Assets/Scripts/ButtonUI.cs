using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonUI : MonoBehaviour
{
    AudioManager audioManager;


    public string changeScene;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void ChangeSceneButton()
    {
        //audioManager.PlaySFX(audioManager.play);
        SceneManager.LoadScene(changeScene);
    }
}
