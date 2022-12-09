using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnStartButton()
    {
        SceneManager.LoadScene("Lv1");
    }

    public void OptionButton()
    {
        Debug.Log("Option");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
