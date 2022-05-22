using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject menuPanel;

    public void MenuPanel()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
    }

    public void Return()
    {
        SceneManager.GetActiveScene();
        Time.timeScale = 1;
    }

    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void play ()
    {
        Time.timeScale = 1;
        menuPanel.SetActive(false);
    }

    public void exit ()
    {
        Application.Quit();
    }
}
