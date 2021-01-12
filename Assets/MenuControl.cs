using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void ChooseLevelPressed()
    {
        SceneManager.LoadScene("4311");
    }

    public void EducationMaterialsPressed()
    {
        //SceneManager.LoadScene("EducationMaterials");
        //Application.OpenURL("http://www.mathprofi.ru/sluchainaya_velichina.html");
    }

    public void RecordsPressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void Level1Pressed()
    {
        SceneManager.LoadScene("Level01_Test");
    }

    public void Level2Pressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void Level3Pressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void Level4Pressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void Level5Pressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void Level6Pressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void Level7Pressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void Level8Pressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void Level9Pressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void Level10Pressed()
    {
        //SceneManager.LoadScene("Records");
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
