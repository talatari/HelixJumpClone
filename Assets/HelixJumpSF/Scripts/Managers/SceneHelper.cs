using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadLevel(int _buildIndex)
    {
        SceneManager.LoadScene(_buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}