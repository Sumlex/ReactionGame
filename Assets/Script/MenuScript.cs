using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject play;
    public GameObject quit;
    public GameObject selLevel;

    
    void Update()
    {
        if (selLevel.activeSelf == true && (Input.GetKey(KeyCode.Backspace) || Input.GetKey(KeyCode.Escape)))
        {
            selLevel.SetActive(false);
            play.SetActive(true);
        }
        
    }

    public void LevelButtons(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void PressPlay()
    {
        play.SetActive(false);
        quit.SetActive(false);
        selLevel.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
