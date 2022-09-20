using System;
using UnityEngine;

public class Points : MonoBehaviour
{
    public event Action<Points> ChangeOfPoints;
    public int quantity{ get; private set; }

    public void AddPoint()
    {
        quantity++;
        ChangeOfPoints(this);
    }
}
