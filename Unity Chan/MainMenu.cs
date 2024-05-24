using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the main menu scene
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}
