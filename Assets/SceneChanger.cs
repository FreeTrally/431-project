using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void ToGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ToTask()
    {
        SceneManager.LoadScene("TaskScene");
    }
    public void ToInv()
    {
        SceneManager.LoadScene("InventoryScene", LoadSceneMode.Additive);
    }
}