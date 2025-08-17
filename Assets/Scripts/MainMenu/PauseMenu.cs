using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    public void TogglePause()
    {
        bool pause = Time.timeScale < 0.5f;
        if (pause) Resume();
        else paused();

    }
    public void paused()
    {
        if (pausePanel != null) pausePanel.SetActive(true);
        Time.timeScale = 0f;

    }
    public void Resume()
    {
        if (pausePanel != null) pausePanel.SetActive(false);
        Time.timeScale = 1f;

    }

    public void BackMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }

   
}