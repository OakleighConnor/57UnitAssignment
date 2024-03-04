using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonUI : MonoBehaviour
{
    public static ButtonUI instance; 

    AudioManager audioManager;

    public string sceneName;

    //public string changeScene;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void ChangeSceneButton()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "Level1")
        {
            print("loaded Menu");
            SceneManager.LoadScene("Menu");
        }
        if (sceneName == "Menu")
        {
            print("Loaded LVL1");
            SceneManager.LoadScene("Level1");
        }
        //audioManager.PlaySFX(audioManager.play);
    }
}
