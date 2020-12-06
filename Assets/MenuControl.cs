using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void ChooseLevelPressed()
    {
        SceneManager.LoadScene("ChooseLevel");
    }

    public void EducationMaterialsPressed()
    {
        SceneManager.LoadScene("EducationMaterials");
        //Открытие ссылки ?
    }

    public void RecordsPressed()
    {
        SceneManager.LoadScene("Records");
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
