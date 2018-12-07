using System.Collections.Generic;
using UnityEngine;

public class key_generator_player1 : MonoBehaviour {
    int rand;
    string currentval;
    List<string> Key = new List<string> { "q", "w", "e", "r", "a", "s", "d", "f", "z", "x", "c" };
    [SerializeField]
    GameObject q;
    GameObject w;
    GameObject e;
    GameObject r;
    GameObject a;
    GameObject s;
    GameObject d;
    GameObject f;
    GameObject z;
    GameObject x;
    GameObject c;
    // Use this for initialization
    void Start ()
    {
        GameManager.Instance.p1 = this;
        GameManager.Instance.p2 = this;
        rand = Random.Range(1, 12);
        currentval = Key[rand];
    }

    // Update is called once per frame
    void Update()
    {
        if (currentval == "q")
        {
            ResetCharacters();
            q.SetActive(true);
        }
        if (currentval == "w")
        {
            ResetCharacters();
            w.SetActive(true);
        }
        if (currentval == "e")
        {
            ResetCharacters();
            e.SetActive(true);
        }
        if (currentval == "r")
        {
            ResetCharacters();
            r.SetActive(true);
        }
        if (currentval == "a")
        {
            ResetCharacters();
            a.SetActive(true);
        }
        if (currentval == "s")
        {
            ResetCharacters();
            s.SetActive(true);
        }
        if (currentval == "d")
        {
            ResetCharacters();
            d.SetActive(true);
        }
        if (currentval == "f")
        {
            ResetCharacters();
            f.SetActive(true);
        }
        if (currentval == "z")
        {
            ResetCharacters();
            z.SetActive(true);
        }
        if (currentval == "x")
        {
            ResetCharacters();
            x.SetActive(true);
        }
        if (currentval == "c")
        {
            ResetCharacters();
            c.SetActive(true);
        }


    }

    void ResetCharacters()
    {
        q.SetActive(false);
        w.SetActive(false);
        e.SetActive(false);
        r.SetActive(false);
        a.SetActive(false);
        s.SetActive(false);
        d.SetActive(false);
        f.SetActive(false);
        z.SetActive(false);
        x.SetActive(false);
        c.SetActive(false);

    }
}

