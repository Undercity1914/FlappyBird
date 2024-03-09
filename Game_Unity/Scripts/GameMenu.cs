using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private string nomeDoJogo;

    public void jogar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nomeDoJogo);
    }
}
