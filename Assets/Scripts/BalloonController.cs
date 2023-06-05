using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public GameObject explosion;
    GameController gameControllerScript;
    private void Start()
    {
        gameControllerScript = GameObject.Find("Scripts").GetComponent<GameController>();
        
    }
    private void OnMouseDown()
    {
        GameObject go = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
        gameControllerScript.scoreController(this.gameObject);
        gameControllerScript.addBalloon();
        Destroy(this.gameObject);
        Destroy(go, 0.333f);
    }
}
