using System;
using UnityEngine;

public class UIExitTheApplicationAction : MonoBehaviour
{
    public static event Action ClickExitTheApplication;

    public void ExitTheApplication()
    {
        ClickExitTheApplication();
    }
}
