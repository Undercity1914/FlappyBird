using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameContoller controller;

    void Start()
    {
        controller = FindObjectOfType<GameContoller>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
