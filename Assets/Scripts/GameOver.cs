using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
        scoreText.text = "SCORE : " + GameController.balloonExploded;
        //GameController.balloonExploded = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OtherPage()
    {
        SceneManager.LoadScene("Main_Scene");
    }
}
