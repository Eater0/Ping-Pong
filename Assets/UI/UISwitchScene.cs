using UnityEngine;
using UnityEngine.SceneManagement;

public class UISwitchScene : MonoBehaviour
{
    void Awake()
    {
        UISwitchSceneAction.ClickSwitchScene += SwitchScene;
    }

    void SwitchScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
        Time.timeScale = 1;
    }

    void OnDestroy()
    {
        UISwitchSceneAction.ClickSwitchScene -= SwitchScene;
    }
}
