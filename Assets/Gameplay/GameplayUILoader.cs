using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUILoader : MonoBehaviour
{
    void Awake()
    {
        SceneManager.LoadScene("GameplayUIScene", LoadSceneMode.Additive);
    }
}
