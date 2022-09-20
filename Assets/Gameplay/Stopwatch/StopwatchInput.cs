using UnityEngine;

public class StopwatchInput : MonoBehaviour
{
    public float timeDelta { get; private set; }

    void Update()
    {
        timeDelta = Time.deltaTime;
    }
}
