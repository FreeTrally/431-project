using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void ExitToMenu()
    {
        SceneManager.LoadScene("(CR)Menu");
    }
}