using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitTheResultOfTheGame : MonoBehaviour
{
    GameResults gameResults;

    void Awake()
    {
        gameResults = new GameResults();
        gameResults.points = new List<int>();

        EndOfTheGame.EventEndGame += Send;
    }

    void Send(List<Points> listPoints, string time)
    {
        foreach (var points in listPoints)
            gameResults.points.Add(points.quantity);

        gameResults.time = time;

        GamesResultsMagazine.gamesResults.Add(gameResults);
        SceneManager.LoadScene("MainMenuScene");
    }

    void OnDestroy()
    {
        EndOfTheGame.EventEndGame -= Send;
    }
}
