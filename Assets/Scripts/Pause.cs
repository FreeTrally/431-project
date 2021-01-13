using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject ui;
    public GameObject world;

    public void Continute()
    {
        ui.SetActive(true);
        world.SetActive(true);
        pausePanel.SetActive(false);
    }

    public void OpenPauseMenu()
    {
        ui.SetActive(false);
        world.SetActive(false);
        pausePanel.SetActive(true);
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("(CR)Menu");
    }
}
