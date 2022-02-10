using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Pedestrian horror Game");
        Time.timeScale = 1;
    }

    public void ExitPressed()
    {
        Application.Quit();
    }

    public void MenuPressed()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void LoadLevelNum (int _LoadScene)
    {
        SceneManager.LoadScene(_LoadScene);
        Time.timeScale = 1;
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }
}
