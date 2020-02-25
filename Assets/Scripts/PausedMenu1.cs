using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu1 : MonoBehaviour
{
    // MainMenu is index 0
    // scene1 is index 1
    // scene2 is index 2
    // scene3 is index 3
    // GameComplete is index 4
    
    [SerializeField] private GameObject pauseMenuUI;
    
    [SerializeField] private bool isPaused;

    private void Update()
    {
        // press escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
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
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1; // time is normal time
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }

    public void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isPaused = false;
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene("MainManu");
        isPaused = false;
    }

    public void QuitGame() 
    {
        isPaused = false;
        Debug.Log("Quit!");
        Application.Quit();
    }
}
