using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastAim : MonoBehaviour
{
    private float secondgametime;
    Miss_aim timer;
    bool plus = false;
    int i = 0;

    private void Awake()
    {
        secondgametime = 2.2f;
        print("Timer = ");

        print(secondgametime);
        timer = FindObjectOfType<Miss_aim>();
    }

    private void Update()
    {
        secondgametime -= Time.deltaTime;
        if (secondgametime < 1.5 && plus != true)
        {
            secondgametime = 2.1f;

            timer.secondgametime = 0.5f;
            gameObject.SetActive(false);
        }
        plus = false;
    }
    private void OnMouseDown()
    {
        secondgametime = 2.1f;
        timer.secondgametime = 0.5f;
        timer.i += 100;
        i++;
        gameObject.SetActive(false);
        plus = true;
    }

    void OnGUI()
    {
        if (timer.maintime > 1) GUI.Label(new Rect(Screen.width - 200, 100, 300, 130), "hit : " + i);
        else
        GUI.Label(new Rect(Screen.width - 450, 160, 300, 130), "hit : " + i);
    }
}
