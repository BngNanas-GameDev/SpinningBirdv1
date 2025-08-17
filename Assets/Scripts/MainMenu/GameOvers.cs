using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOvers : MonoBehaviour
{
    [SerializeField] private GameObject Over;
    public void Awake()
    {
        if (Over != null) Over.SetActive(false);
    }
    public void Show()
    {
        if (Over != null) Over.SetActive(true);
        Time.timeScale = 0f;

    }
    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void BackMenu()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(0);
    }
}