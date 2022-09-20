using System;
using UnityEngine;

public class BallOutOfBounds : MonoBehaviour
{
    public static event Action TheBallIsOutOfBounds;

    void OnTriggerEnter2D()
    {
        TheBallIsOutOfBounds();
    }
}
