using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Miss_aim : MonoBehaviour
{
    //Переменные для спавна целей
    float SpawnX, SpawnY, X2, Y2, spawnZ = -3;
    //Игровые объекты - цели
    public GameObject aim;

    //Canvas(холст), на котором будут отображены результаты игры
    public GameObject scores;

    //float[] score = new float[20];

    // Таймер
    public float maintime = 120, secondgametime;
    //Счетчик
    public int i = 0;
    public int miss = 0;

    void Start()
    {
        secondgametime = 2.2f;
    }

    public void Update()
    {
        maintime -= Time.deltaTime;
        secondgametime -= Time.deltaTime;

        SpawnX = Random.Range(-10f, 10f);
        SpawnY = Random.Range(-4f, 4f);

        Vector3 pos = new Vector3(SpawnX, SpawnY, spawnZ);


        if (secondgametime < 1.5)
        {
            aim.transform.position = pos;
                secondgametime = 2.1f;
            aim.SetActive(true);
        }
        
        if (maintime <= 0)
        {
            Time.timeScale = 0;
        }
    }

    private void OnMouseDown()
    {
        i -= 120;
        miss++;
    }


    void OnGUI()
    {
        //Screen.width не даёт расползаться GUI (Графический элемент) по всему экрану, на разных по размеру экранам
        if (maintime > 1)
        {
            GUI.Label(new Rect(Screen.width - 200, 20, 300, 50), "Time left : " + maintime);
            GUI.Label(new Rect(Screen.width - 200, 70, 300, 100), "Score : " + i);
            GUI.Label(new Rect(Screen.width - 200, 130, 300, 160), "Misses : " + miss);
        }
        else
        {
            GUI.Label(new Rect(Screen.width - 460, 130, 300, 50), "Your total score: ");
            GUI.Label(new Rect(Screen.width - 450, 190, 300, 100), "Score : " + i);
            GUI.Label(new Rect(Screen.width - 450, 220, 300, 160), "Misses : " + miss);
            GUI.Label(new Rect(Screen.width - 465, 70, 350, 200), "Press \"Escape\" to exit");
        }
    }
}
