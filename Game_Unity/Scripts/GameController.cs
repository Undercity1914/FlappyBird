using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public void start()
    {
        Time.timeScale = 1;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(0);
        start();
    }
}
