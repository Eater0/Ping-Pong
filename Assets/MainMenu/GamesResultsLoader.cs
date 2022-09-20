using UnityEngine;
using UnityEngine.SceneManagement;

public class GamesResultsLoader : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.UnloadSceneAsync("GamesResultsScene");
    }
}
