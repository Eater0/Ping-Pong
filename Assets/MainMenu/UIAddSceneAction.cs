using System;
using UnityEngine;

public class UIAddSceneAction : MonoBehaviour
{
    public static event Action<string> ClickAddScene;

    public void AddScene(string nameScene)
    {
        ClickAddScene(nameScene);
    }
}
