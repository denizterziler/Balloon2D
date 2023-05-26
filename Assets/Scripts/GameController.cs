using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text timerText, balloonText;
    public float timer = 15;
    public float delay = 1.5f;
    public float delayTimer = 0;
    public GameObject explosion;
    public static int balloonExploded;
    void Start()
    {
        balloonExploded = 0;
        balloonText.text = "Balloon: " + balloonExploded;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = "Time: " + (int)timer;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("Balloon");
            for(int i = 0;i < go.Length; i++)
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
    public void addBalloon()
    {
        balloonExploded += 1;
        balloonText.text = "Balloon: " + balloonExploded;
    }

}
