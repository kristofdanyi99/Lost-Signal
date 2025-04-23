using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OpenSettings()
    {
        Debug.Log("Settings clicked - not implemented yet");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit clicked - will only work in a build");
    }
}
