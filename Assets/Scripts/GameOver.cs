using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText,failOrNotText;
    
    // Start is called before the first frame update
    void Start()
    {
        
        scoreText.text = "SCORE : " + GameController.score;
        
        if(GameController.score >= GameController.goal)
        {
            failOrNotText.text = "SUCCESS";
        }
        else
        {
            failOrNotText.text = "FAIL";
        }
    }
    public void Main_Page()
    {
        SceneManager.LoadScene("Main_Scene");
    }
}
