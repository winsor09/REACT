using UnityEngine;

public class GameManager
{
    [SerializeField]
    GameObject p1win;
    [SerializeField]
    GameObject p2Win;
    int p2score = 0;
    int p1score = 0;
    bool istimerrunning = true;
    float timer = 0f;
    float time2goal = 3f;
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
        p1win = GameObject.Find("P1win");
        p2Win = GameObject.Find("P2Win");
        p1win.SetActive(false);
        p2Win.SetActive(false);
    }

    private void Update()
    {
        
        Timer();

    }
   

    public void player2wins()
    {
        p2Win.SetActive(true);
        if(!istimerrunning)
        {
            timer = 0;
            p1.ResetCharacters();
            p2.ResetCharacters();
            p2score++;
            istimerrunning = true;
          
        }

    }

    public void player1wins()
    {
        p1win.SetActive(true);

        if (!istimerrunning)
        {
            p1.ResetCharacters();
            p2.ResetCharacters();
            p1score++;
            istimerrunning = true;
        }
    }
  

    public void Timer()
    {

        if (istimerrunning == true)
        {
            timer += Time.deltaTime;
        }




        if (timer >= time2goal)
        {
            istimerrunning = false;

            timer = 0;
            p2.setchar();
            p1.setchar();
            p1win.SetActive(false);
            p2Win.SetActive(false);


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

