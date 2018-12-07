using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class key_generator_player2 : MonoBehaviour {
    int rand;
    string currentval;
    List<string> Key = new List<string> { "u", "i", "o", "p", "h", "j", "k", "l", "b", "n", "m" };

    [SerializeField]
    GameObject u;
    GameObject i;
    GameObject o;
    GameObject p;
    GameObject h;
    GameObject j;
    GameObject k;
    GameObject l;
    GameObject b;
    GameObject n;
    GameObject m;

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
            ResetCharacters();
            u.SetActive(true);
        }
        if (currentval == "i")
        {
            ResetCharacters();
            i.SetActive(true);

        }
        if (currentval == "o")
        {
            ResetCharacters();
            o.SetActive(true);
        }
        if (currentval == "p")
        {
            ResetCharacters();
            p.SetActive(true);

        }
        if (currentval == "h")
        {
            ResetCharacters();
            h.SetActive(true);

        }
        if (currentval == "j")
        {
            ResetCharacters();
            j.SetActive(true);

        }
        if (currentval == "k")
        {
            ResetCharacters();
            k.SetActive(true);

        }
        if (currentval == "l")
        {
            ResetCharacters();
            l.SetActive(true);

        }
        if (currentval == "b")
        {
            ResetCharacters();
            b.SetActive(true);

        }
        if (currentval == "n")
        {
            ResetCharacters();
            n.SetActive(true);

        }
        if (currentval == "m")
        {
            ResetCharacters();
            m.SetActive(true);

        }
    }

    void ResetCharacters()
    {
        u.SetActive(false);
        i.SetActive(false);
        o.SetActive(false);
        p.SetActive(false);
        h.SetActive(false);
        j.SetActive(false);
        k.SetActive(false);
        l.SetActive(false);
        b.SetActive(false);
        n.SetActive(false);
        m.SetActive(false);

    }
}
