using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeOption : MonoBehaviour
{
    public void OtherPage(int input)
    {
        SceneManager.LoadScene("Game_Scene");
    }
}
