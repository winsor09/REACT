using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    float timer = 0f;
    float time2goal = 10f;
    static GameManager instance;

    public static GameManager Instance
    {
        get { return instance ?? ((instance = new GameManager())); }
    }

    public key_generator_player1 p1
    {
        get; set;
    }

    public key_generator_player2 p2
    {
        get; set;
    }

    private GameManager()
    {
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }

    private void Update()
    {
    }


    public void Timer()
    {
        float timer = 0;

        timer = Time.deltaTime;


    }




    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }
}

