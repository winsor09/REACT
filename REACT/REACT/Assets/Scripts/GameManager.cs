using UnityEngine;

public class GameManager
{
    float timetillp1 = 0f;
    float tiltillp2 = 0f;
    bool p1press = false;
    bool p2press = false;
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
    }

    private void Update()
    {
        Timer();

    }

    public void player2wins()
    {
        p1.ResetCharacters();
        p2.ResetCharacters();
        p2score++;
    }

    public void player1wins()
    {
        p1.ResetCharacters();
        p2.ResetCharacters();
        p1score++;
    }
  public void p1pressed()
    {
     
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

