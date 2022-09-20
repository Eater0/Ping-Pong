using UnityEngine;

public class UIExitTheApplication : MonoBehaviour
{
    void Awake()
    {
        UIExitTheApplicationAction.ClickExitTheApplication += ExitTheApplication;
    }

    void ExitTheApplication()
    {
        Application.Quit();
    }

    void OnDestroy()
    {
        UIExitTheApplicationAction.ClickExitTheApplication -= ExitTheApplication;
    }
}
