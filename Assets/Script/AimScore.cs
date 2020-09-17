using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AimScore : MonoBehaviour
{
    //Переменные для спавна целей
    float SpawnX, SpawnY,X2, Y2, spawnZ = -3;
    //Игровые объекты - цели
    public GameObject aim, aim2;
    
    //Canvas(холст), на котором будут отображены результаты игры
    public GameObject table;

    //float[] score = new float[20];

    // Таймер
    public float maintime = 0, secondgametime, secondgametime2, timer;
    //Счетчик
    public int i = 0;

    void Start()
    {
        secondgametime = 3;
        secondgametime2 = 2.5f;
        timer = 0;
    }

    public void Update()
    {
        maintime += Time.deltaTime;     
        secondgametime -= Time.deltaTime;
        secondgametime2 -= Time.deltaTime;
        timer += Time.deltaTime;

            SpawnX = Random.Range(-10f, 10f);
            SpawnY = Random.Range(-4f, 4f);

            X2 = Random.Range(-10f, 10f);
            Y2 = Random.Range(-4f, 4f);
        Vector3 pos = new Vector3(SpawnX, SpawnY, spawnZ);
        Vector3 pos2 = new Vector3(SpawnX, SpawnY, spawnZ);


        if (secondgametime < 1.5)
            {
                aim.transform.position = pos;
            if (i >= 2000)
            {
                secondgametime = 2.5f;
            }
            else secondgametime = 3f;

            aim.SetActive(true);  
            }
        if (secondgametime2 < 1)
        {
            aim2.transform.position = pos2;

            if (i >= 2000)
            {
                secondgametime2 = 2.0f;
            }
            else secondgametime2 = 2.5f;

            aim2.SetActive(true);
        }
        if (maintime > 119)
        {
            Time.timeScale = 0;
        }
    }


    void OnGUI()
    {
        //Screen.width не даёт расползаться GUI (Графический элемент) по всему экрану, на разных по размеру экранам
        if (maintime < 119)
        {
            GUI.Label(new Rect(Screen.width - 200, 50, 300, 100), "Time : " + maintime);
            GUI.Label(new Rect(Screen.width - 200, 80, 300, 130), "Score : " + i);
        }
        else
        {
            GUI.Label(new Rect(Screen.width - 450, 130, 300, 50), "Your total score: ");
            GUI.Label(new Rect(Screen.width - 446, 160, 300, 130), "Score : " + i);
            GUI.Label(new Rect(Screen.width - 465, 70, 350, 200), "Press \"Escape\" to exit");
        }
    }
}
