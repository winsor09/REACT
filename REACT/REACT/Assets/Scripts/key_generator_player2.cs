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
    [SerializeField]
    GameObject i;
    [SerializeField]
    GameObject o;
    [SerializeField]
    GameObject p;
    [SerializeField]
    GameObject h;
    [SerializeField]
    GameObject j;
    [SerializeField]
    GameObject k;
    [SerializeField]
    GameObject l;
    [SerializeField]
    GameObject b;
    [SerializeField]
    GameObject n;
    [SerializeField]
    GameObject m;
   

    // Use this for initialization
    void Start () {
        GameManager.Instance.p2 = this;
        rand = Random.Range(1, 12);
        currentval = Key[rand];

    }

    // Update is called once per frame
    void Update ()
    {
        if (currentval == "u")
        {
            
            u.SetActive(true);
        }

        if (currentval == "u" && Input.GetKeyDown("u"))
        {
            u.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "i")
        {
            
            i.SetActive(true);

        }

        if (currentval == "i" && Input.GetKeyDown("i"))
        {
            i.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "o")
        {
           
            o.SetActive(true);
        }

        if (currentval == "o" && Input.GetKeyDown("o"))
        {
            o.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "p")
        {
            
            p.SetActive(true);

        }

        if (currentval == "p" && Input.GetKeyDown("p"))
        {
            p.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "h")
        {
            
            h.SetActive(true);

        }

        if (currentval == "h" && Input.GetKeyDown("h"))
        {
            h.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "j")
        {
            
            j.SetActive(true);

        }

        if (currentval == "j" && Input.GetKeyDown("j"))
        {
            j.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "k")
        {
            
            k.SetActive(true);

        }

        if (currentval == "k" && Input.GetKeyDown("k"))
        {
            k.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "l")
        {
            
            l.SetActive(true);

        }

        if (currentval == "l" && Input.GetKeyDown("l"))
        {
            l.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "b")
        {
            
            b.SetActive(true);

        }

        if (currentval == "b" && Input.GetKeyDown("b"))
        {
            b.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "n")
        {
            
            n.SetActive(true);

        }

        if (currentval == "n" && Input.GetKeyDown("n"))
        {
            n.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

        if (currentval == "m")
        {
           
            m.SetActive(true);

        }

        if (currentval == "m" && Input.GetKeyDown("m"))
        {
            m.SetActive(false);
            currentval = "";
            ResetCharacters();
            GameManager.Instance.player2wins();
        }

    }

    public void ResetCharacters()
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
        currentval = "";

    }
}
