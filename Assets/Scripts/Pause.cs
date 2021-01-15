using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject ui;
    public GameObject world;
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject inv;
    public GameObject task;

    public void Continute()
    {
        ui.SetActive(true);
        world.SetActive(true);
        inv.SetActive(true);
        pausePanel.SetActive(false);
    }

    public void OpenPauseMenu()
    {
        ui.SetActive(false);
        world.SetActive(false);
        inv.SetActive(false);
        pausePanel.SetActive(true);
    }

    public void Win()
    {
        ui.SetActive(false);
        world.SetActive(false);
        inv.SetActive(false);
        task.SetActive(false);
        winScreen.SetActive(true);
    }

    public void Lose()
    {
        ui.SetActive(false);
        world.SetActive(false);
        inv.SetActive(false);
        loseScreen.SetActive(true);
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("(CR)Menu");
    }
}
