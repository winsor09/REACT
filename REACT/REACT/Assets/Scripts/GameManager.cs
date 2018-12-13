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
        Timer();
    }

    public void player2wins()
    {
        p1.ResetCharacters();
        p2.ResetCharacters();
    }

    public void player1wins()
    {
        p1.ResetCharacters();

        p2.ResetCharacters();
    }


    public void Timer()
    {
        float timer = 0;

        timer = Time.deltaTime;
        if(timer >= time2goal)
        {
            timer = 0;
            
        }

    }






    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }
}

