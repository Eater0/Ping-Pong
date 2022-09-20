using TMPro;
using UnityEngine;

public class UITime : MonoBehaviour
{
    TextMeshProUGUI text;

    void Awake()
    {
        Stopwatch.Time += ViewTime;
        text = GetComponent<TextMeshProUGUI>();
    }

    void ViewTime(string time)
    {
        text.text = time;
    }

    void OnDestroy()
    {
        Stopwatch.Time -= ViewTime;
    }
}
