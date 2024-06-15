using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ShowCredits()
    {
        // Implement credits display logic
        Debug.Log("Credits");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
