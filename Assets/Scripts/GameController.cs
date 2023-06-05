using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{

    public UnityEngine.UI.Text timerText, balloonText, goalText, scoreText;
    public static float timer;
    public static int score;
    public static int goal;
    public float delay = 1.5f;
    public float delayTimer = 0;
    public GameObject explosion;
    public static int balloonExploded;
    void Start()
    {
        score = 0;
        balloonExploded = 0;
        balloonText.text = "Balloon: " + balloonExploded;
        goalText.text = "Goal: " + goal;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = "Time: " + (int)timer;
            scoreText.text = "Score: " + score;   
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("Balloon");
            for (int i = 0; i < go.Length; i++)
            {
                
                GameObject gameObject = Instantiate(explosion, go[i].transform.position, go[i].transform.rotation) as GameObject;
                Destroy(go[i]);
                Destroy(gameObject, 0.333f);
                
            }
            delayTimer += Time.deltaTime;
            if (delayTimer > delay)
            {

                SceneManager.LoadScene("Game_Over");
            }
    

        }
    }
    public void scoreController(GameObject gameObject)
    {
        if (gameObject.name == "balloon_yellow(Clone)")
        {
            score += 5;
        }
        else if (gameObject.name == "balloon_red(Clone)")
        {
            score += 10;
        }
        else if (gameObject.name == "balloon_orange(Clone)")
        {
            score += 15;
        }
        else if (gameObject.name == "balloon_green(Clone)")
        {
            score += 20;
        }
        else if(gameObject.name == "balloon_black(Clone)")
        {
            score += 50;
        }
    }
    public void addBalloon()
    {
        balloonExploded += 1;
        balloonText.text = "Balloon: " + balloonExploded;
    }

}
