using System.Collections.Generic;
using UnityEngine;

public class key_generator_player1 : MonoBehaviour {
    int rand;
    string currentval;
    List<string> Key = new List<string> { "q", "w", "e", "r", "a", "s", "d", "f", "z", "x", "c" };

    // Use this for initialization
    void Start ()
    {
        rand = Random.Range(1, 12);
        currentval = Key[rand];
    }

    // Update is called once per frame
    void Update()
    {
        if (currentval == "q")
        {

        }
        if (currentval == "w")
        {

        }
        if (currentval == "e")
        {

        }
        if (currentval == "r")
        {

        }
        if (currentval == "a")
        {

        }
        if (currentval == "s")
        {

        }
        if (currentval == "d")
        {

        }
        if (currentval == "f")
        {

        }
        if (currentval == "z")
        {

        }
        if (currentval == "x")
        {

        }
        if (currentval == "c")
        {

        }


    }
}

