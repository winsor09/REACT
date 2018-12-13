using System.Collections.Generic;
using UnityEngine;

public class key_generator_player1 : MonoBehaviour {
    int rand;
    string currentval;
    List<string> Key = new List<string> { "q", "w", "e", "r", "a", "s", "d", "f", "z", "x", "c" };
    [SerializeField]
    GameObject q;
    [SerializeField]
    GameObject w;
    [SerializeField]
    GameObject e;
    [SerializeField]
    GameObject r;
    [SerializeField]
    GameObject a;
    [SerializeField]
    GameObject s;
    [SerializeField]
    GameObject d;
    [SerializeField]
    GameObject f;
    [SerializeField]
    GameObject z;
    [SerializeField]
    GameObject x;
    [SerializeField]
    GameObject c;
    [SerializeField]
    // Use this for initialization
    void Start ()
    {
        GameManager.Instance.p1 = this;
        rand = Random.Range(1, 12);
        currentval = Key[rand];
    }

    // Update is called once per frame
    void Update()
    {
        if (currentval == "q")
        {
            
            q.SetActive(true);
        }

        if (currentval == "q" && Input.GetKeyDown("q"))
        {
            q.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "w")
        {
           
            w.SetActive(true);
        }

        if (currentval == "w" && Input.GetKeyDown("w"))
        {
            w.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "e")
        {
            
            e.SetActive(true);
        }

        if (currentval == "e" && Input.GetKeyDown("e"))
        {
            e.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "r")
        {
            
            r.SetActive(true);
        }

        if (currentval == "r" && Input.GetKeyDown("r"))
        {
            r.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "a")
        {
            
            a.SetActive(true);
        }

        if (currentval == "a" && Input.GetKeyDown("a"))
        {
            a.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "s")
        {
            
            s.SetActive(true);
        }

        if (currentval == "s" && Input.GetKeyDown("s"))
        {
            s.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "d")
        {
            
            d.SetActive(true);
        }

        if (currentval == "d" && Input.GetKeyDown("d"))
        {
            d.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "f")
        {
            
            f.SetActive(true);
        }
        
        if (currentval == "f" && Input.GetKeyDown("f"))
        {
            f.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "z")
        {
            
            z.SetActive(true);
        }

        if (currentval == "z" && Input.GetKeyDown("z"))
        {
            z.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "x")
        {
            
            x.SetActive(true);
        }

        if (currentval == "x" && Input.GetKeyDown("x"))
        {
            x.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }

        if (currentval == "c")
        {
            
            c.SetActive(true);
        }

        if (currentval == "c" && Input.GetKeyDown("c"))
        {
            c.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player1wins();
        }


    }

    public void ResetCharacters()
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
        currentval = "";

    }
}

