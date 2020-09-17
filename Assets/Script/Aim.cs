using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    private float secondgametime;
    AimScore timer;
    bool plus = false;

    private void Awake()
    {
        secondgametime = 3f;
        print("Timer = ");

        print(secondgametime);
        timer = FindObjectOfType<AimScore>();
    }

    private void Update()
    {
        secondgametime -= Time.deltaTime;
        if (secondgametime < 1.5 && plus != true)
        {
            if (timer.i >= 2000)
            {
                secondgametime = 2.5f;
            }
            else secondgametime = 3.0f;

            timer.secondgametime = 0.5f;
            gameObject.SetActive(false);
            timer.i -= 120;
        }
        plus = false;
    }
    private void OnMouseDown()
    {
        secondgametime = 3;
        timer.secondgametime = 0.5f;
        gameObject.SetActive(false);
        timer.i += 100;
        plus = true;
    }
}

