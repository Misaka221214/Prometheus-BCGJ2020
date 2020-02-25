using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // MainMenu is index 0
    // scene1 is index 1
    // scene2 is index 2
    // scene3 is index 3
    // GameComplete is index 4
    
    // public SettingsMenu settingsMenu;

    // start with tutorial
    public void PlayGame() {
        Debug.Log("Start");
        SceneManager.LoadScene("Level0Scene");
    }

    public void Settings() 
    {
        Debug.Log("Settings");
        // SceneManager.LoadScene("Settings");
    }

    public void About()
    {
        Debug.Log("About");
        // TODO
    }

    public void QuitGame() 
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
