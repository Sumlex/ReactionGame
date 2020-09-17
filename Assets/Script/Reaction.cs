using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaction : MonoBehaviour
{
    private float FstTime, recTime = 0;
    private SpriteRenderer sprite;
    CircleCollider2D col;
    float[] score = new float[11];
    int i = 0;

    private void Awake()
    {
        FstTime = Random.Range(3, 10);
        sprite = GetComponent<SpriteRenderer>();
        col = GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        FstTime -= Time.deltaTime;
        if (FstTime < 1)
        {
            if(i<=9)
            {
                sprite.color = new Color(1, 1, 1, 1);
                recTime += Time.deltaTime;
                if (i == 9)
                {
                    sprite.color = new Color(255, 0, 0, 1);
                    Time.timeScale = 0;
                    col.enabled = false;
                    FstTime = 0;
                    CenterNumber();
                    i = 10; 
                }
            }
        }
    }
    private void OnMouseDown()
    {
        if (FstTime < 1)
        {
            FstTime = Random.Range(3, 10);
            sprite.color = new Color(255, 0, 0, 1);
            i++;
            score[i] = recTime;
            recTime = 0;
            print("Ваша реакция = " + score[i]);
        }
    }

    float number;
    private void CenterNumber()
    {
        if (col.enabled == false)
        {
            for (int i = 0; i<9; i++)
            {
                number += score[i];
            }
        }
        
        number = number / 10;  
        print("Средняя реакция" + number);
    }
    void OnGUI()
    {
        if (i <= 9)
        {
            GUI.Label(new Rect(Screen.width - 200, 50, 300, 100), "Reaction Time : " + score[i]);
        }
        else
        {
            GUI.Label(new Rect(Screen.width - 450, 190, 300, 100), "Average reaction : " + number);
            GUI.Label(new Rect(Screen.width - 465, 70, 350, 200), "Press \"Escape\" to exit");
        }
    }
    
}
