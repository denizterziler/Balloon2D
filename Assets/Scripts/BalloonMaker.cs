using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMaker : MonoBehaviour
{
    public GameObject balloon;
    float produceTime = 1f;
    float timer = 0f;
    GameController gameControllerScript;
    void Start()
    {
        gameControllerScript = this.gameObject.GetComponent<GameController>();
    }

    void Update()
    {
        int multiplier = (int)(gameControllerScript.timer / 10) - 6;
        multiplier *= -1;
        timer -= Time.deltaTime;
        if(timer < 0 && gameControllerScript.timer > 0)
        {
            GameObject go = Instantiate(balloon, new Vector3(Random.Range(-7.50f,7.5f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(multiplier*50f,multiplier*100f), 0));
            timer = produceTime;
        }
        
    }
}
