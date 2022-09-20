using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayMenuLoader : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!SceneManager.GetSceneByName("GameplayMenuScene").isLoaded)
            {
                SceneManager.LoadSceneAsync("GameplayMenuScene", LoadSceneMode.Additive);
                Time.timeScale = 0;
            }
            else
            {
                SceneManager.UnloadSceneAsync("GameplayMenuScene");
                Time.timeScale = 1;
            }
        }
    }
}
