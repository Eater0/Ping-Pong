using System;
using UnityEngine;

[RequireComponent(typeof(StopwatchInput))]
public class Stopwatch : MonoBehaviour
{
    public static event Action<string> Time;
    public static string time;
    float timeiInSec;

    StopwatchInput stopwatchInput;

    void Awake()
    {
        stopwatchInput = GetComponent<StopwatchInput>();
    }

    void Update()
    {
        timeiInSec += stopwatchInput.timeDelta;
        TimeSpan timeS = TimeSpan.FromSeconds(timeiInSec);
        time = timeS.ToString(@"mm\:ss");

        Time(time);
    }
}
