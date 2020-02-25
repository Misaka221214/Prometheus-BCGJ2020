using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    // MainMenu is index 0
    // scene1 is index 1
    // scene2 is index 2
    // scene3 is index 3
    // GameComplete is index 4

    [SerializeField] private GameObject settingsUI;
    
    [SerializeField] public bool settingsChosen;

    private void Update()
    {

        if (settingsChosen)
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
        settingsUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        
        settingsUI.SetActive(false);
    }

    public void Back() {
        Debug.Log("Back to Main Menu");
        SceneManager.LoadScene("MainManu");
    }
}
