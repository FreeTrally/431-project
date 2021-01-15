using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Threading.Tasks;

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
        StartCoroutine(TrueWin());
    }

    public void Lose()
    {
        StartCoroutine(TrueLose());
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("(CR)Menu");
    }

    IEnumerator TrueWin()
    {
        ui.SetActive(false);
        world.SetActive(false);
        inv.SetActive(false);
        task.SetActive(false);
        yield return new WaitForSeconds(1);
        winScreen.SetActive(true);
    }

    IEnumerator TrueLose()
    {
        ui.SetActive(false);
        world.SetActive(false);
        inv.SetActive(false);
        yield return new WaitForSeconds(1);
        loseScreen.SetActive(true);
    }
}
