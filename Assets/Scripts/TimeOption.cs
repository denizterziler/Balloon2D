using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeOption : MonoBehaviour
{
    public void OtherPage(int selectedTime)
    {
        GameController.timer = selectedTime;
        GameController.goal = selectedTime * 10;
        SceneManager.LoadScene("Game_Scene");
    }
}
