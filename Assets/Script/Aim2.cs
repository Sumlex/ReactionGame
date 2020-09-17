using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim2 : MonoBehaviour
{
    private float secondgametime;
    AimScore timer;
    bool plus = false;

    private void Awake()
    {
        secondgametime = 2.5f;
        print("Timer = ");

        print(secondgametime);
        timer = FindObjectOfType<AimScore>();
    }

    private void Update()
    {
        secondgametime -= Time.deltaTime;
        if (secondgametime < 1 && plus != true)
        {
            
            timer.secondgametime2 = 0.5f;
            gameObject.SetActive(false);
            timer.i -= 120;
            if (timer.i >= 2000)
            {
                secondgametime = 2.0f;
            }
            else secondgametime = 2.5f;
        }
        plus = false;
    }
    private void OnMouseDown()
    {
        if (timer.i >= 2000)
        {
            secondgametime = 2.0f;
        }
        else secondgametime = 2.5f;

        timer.secondgametime2 = 0.5f;
        gameObject.SetActive(false);
        timer.i += 100;
        plus = true;
    }
}

