using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUMANAGER : MonoBehaviour
{
    [SerializeField] private string LevelGame;

    public void PlayGameButton()
    {
        SceneManager.LoadScene(LevelGame);
    }
    public void QuitGameButton()
    {
        Debug.Log("SAIR DO JOGO");
        Application.Quit();
    }
}