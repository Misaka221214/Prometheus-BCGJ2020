using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainMenu : MonoBehaviour
{
    // MainMenu is index 0
    // Level0Scene is index 1
    // Level1Scene1 is index 2
    // Level2Scene is index 3
    // Level3Scene is index 4
    // Level4Scene is index 5
    // TryAgain is index 6
    // GameComplete is index 7
    
    // go to gameplay
    public void TryAgain(int index) 
    {
        Debug.Log("Try Again");
        SceneManager.LoadScene(index);
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene("MainManu");
    }

    public void QuitGame() 
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
