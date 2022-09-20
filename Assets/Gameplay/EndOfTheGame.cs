using System;
using System.Collections.Generic;
using UnityEngine;

public class EndOfTheGame : MonoBehaviour
{
    public static event Action<List<Points>, string> EventEndGame;

    [SerializeField] int pointsNeeded;
    List<Points> listPoints;

    void Start()
    {
        listPoints = PointsData.listPoints;

        foreach (var points in listPoints)
            points.ChangeOfPoints += IfEndGame;
    }

    void IfEndGame(Points points)
    {
        if (points.quantity == pointsNeeded)
            EventEndGame(listPoints, Stopwatch.time);
    }

    void OnDestroy()
    {
        foreach (var points in listPoints)
            points.ChangeOfPoints -= IfEndGame;
    }
}
