using System.Collections.Generic;
using UnityEngine;

public class PointsData : MonoBehaviour
{
    public static List<Points> listPoints;
    [SerializeField] List<Points> points;

    void Start()
    {
        listPoints = points;
    }
}
