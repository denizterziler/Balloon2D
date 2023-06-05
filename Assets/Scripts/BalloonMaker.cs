using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMaker : MonoBehaviour
{
    public GameObject[] balloon;
    float produceTime = 1f;
    float timer = 0f;
    GameController gameControllerScript;
    void Start()
    {
        gameControllerScript = this.gameObject.GetComponent<GameController>();
    }

    void Update()
    {
        int multiplier = (int)(GameController.timer / 10) - 6;
        multiplier *= -1;
        timer -= Time.deltaTime;
        int probability = Random.Range(0, 100);
        if (timer < 0 && GameController.timer > 0)
        {

            if (probability > 0 && probability < 8)
            {
                GameObject go = Instantiate(balloon[4], new Vector3(Random.Range(-7.50f, 7.5f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(multiplier * 50f, multiplier * 100f), 0));
                timer = produceTime;
            }
            else
            {
                GameObject go = Instantiate(balloon[Random.Range(0,4)], new Vector3(Random.Range(-7.50f, 7.5f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(multiplier * 50f, multiplier * 100f), 0));
                timer = produceTime;
            }
        }
        
    }
}
