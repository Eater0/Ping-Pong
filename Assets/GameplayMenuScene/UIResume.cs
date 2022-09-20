using UnityEngine;
using UnityEngine.SceneManagement;

public class UIResume : MonoBehaviour
{
    void Awake()
    {
        UIResumeAction.ClickResume += Resume;
    }

    public void Resume()
    {
        SceneManager.UnloadSceneAsync("GameplayMenuScene");
        Time.timeScale = 1;
    }

    void OnDestroy()
    {
        UIResumeAction.ClickResume -= Resume;
    }
}
