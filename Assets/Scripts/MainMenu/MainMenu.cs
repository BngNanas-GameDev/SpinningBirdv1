using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int gameSceneIndex = 1;

    public void GameStart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(gameSceneIndex);

    }
    public void GameEnd()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else 
        Application.Quit();
#endif
    }

    [SerializeField] private GameObject setting;
    public void OpenSettings(bool open)
    {
        if (setting != null) setting.SetActive(open);

    }
}