using System;
using UnityEngine;

public class UISwitchSceneAction: MonoBehaviour
{
    public static event Action<string> ClickSwitchScene;

    public void SwitchScene(string sceneName)
    {
        ClickSwitchScene(sceneName);
    }
}
