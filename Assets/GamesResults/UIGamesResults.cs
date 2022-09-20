using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGamesResults : MonoBehaviour
{
    [SerializeField] GameObject gameResult;
    List<GameResults> gamesResults;
    GameObject UIGameResults;

    void Awake()
    {
        gamesResults = GamesResultsMagazine.gamesResults;

        foreach (var _gameResults in gamesResults)
        {
            UIGameResults = Instantiate(gameResult);
            UIGameResults.transform.SetParent(gameObject.transform);

            UIGameResults.transform.GetChild(0).
                GetComponent<TextMeshProUGUI>().text = _gameResults.points[0].ToString();
            UIGameResults.transform.GetChild(1).
                GetComponent<TextMeshProUGUI>().text = _gameResults.time;
            UIGameResults.transform.GetChild(2).
                GetComponent<TextMeshProUGUI>().text = _gameResults.points[1].ToString();
        }
    }
}
