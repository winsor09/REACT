using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_generator_player2 : MonoBehaviour {
    int rand;
    string currentval;
    List<string> Key = new List<string> { "u", "i", "o", "p", "h", "j", "k", "l", "b", "n", "m" };

    // Use this for initialization
    void Start () {
        rand = Random.Range(1, 12);
        currentval = Key[rand];

    }

    // Update is called once per frame
    void Update ()
    {
        if (currentval == "u")
        {

        }
        if (currentval == "i")
        {

        }
        if (currentval == "o")
        {

        }
        if (currentval == "p")
        {

        }
        if (currentval == "h")
        {

        }
        if (currentval == "j")
        {

        }
        if (currentval == "k")
        {

        }
        if (currentval == "l")
        {

        }
        if (currentval == "b")
        {

        }
        if (currentval == "n")
        {

        }
        if (currentval == "m")
        {

        }
    }
}
