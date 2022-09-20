using UnityEngine;
using UnityEngine.SceneManagement;

public class UIAddScene : MonoBehaviour
{
    void Awake()
    {
        UIAddSceneAction.ClickAddScene += AddScene;
    }

    void AddScene(string nameScene)
    {
        SceneManager.LoadSceneAsync(nameScene, LoadSceneMode.Additive);
    }

    void OnDestroy()
    {
        UIAddSceneAction.ClickAddScene -= AddScene;
    }
}
