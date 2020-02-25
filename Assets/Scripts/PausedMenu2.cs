using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu2 : MonoBehaviour
{

    // MainMenu is index 0
    // scene1 is index 1
    // scene2 is index 2
    // scene3 is index 3
    // GameComplete is index 4

    [SerializeField] private GameObject pauseMenuUI2;
    
    [SerializeField] private bool isPaused2;

    private void Update()
    {
        // press escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused2 = !isPaused2;
        }

        if (isPaused2)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {   
        Time.timeScale = 0; // stops time
        AudioListener.pause = true;
        pauseMenuUI2.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1; // time is normal time
        AudioListener.pause = false;
        pauseMenuUI2.SetActive(false);
        isPaused2 = false;
    }

    public void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isPaused2 = false;
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        isPaused2 = false;
    }

    public void QuitGame() 
    {
        isPaused2 = false;
        Debug.Log("Quit!");
        Application.Quit();
    }
}
