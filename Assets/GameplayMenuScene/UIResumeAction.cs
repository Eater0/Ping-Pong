using System;
using UnityEngine;

public class UIResumeAction : MonoBehaviour
{
    public static event Action ClickResume;

    public void Resume()
    {
        ClickResume();
    }
}
