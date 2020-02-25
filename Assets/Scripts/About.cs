using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour
{
    // MainMenu is index 0
    // scene1 is index 1
    // scene2 is index 2
    // scene3 is index 3
    // GameComplete is index 4

    // goes back to MainMenu
    public void Back() {
        Debug.Log("About");
        SceneManager.LoadScene("MainManu");
    }
}
