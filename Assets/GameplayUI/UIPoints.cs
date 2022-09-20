using TMPro;
using UnityEngine;

public class UIPoints : MonoBehaviour
{
    [SerializeField] int pointsIndex;

    Points points;
    TextMeshProUGUI text;

    void Start()
    {
        points = PointsData.listPoints[pointsIndex];
        points.ChangeOfPoints += ChangeText;

        text = GetComponent<TextMeshProUGUI>();
    }

    void ChangeText(Points points)
    {
        text.text = points.quantity.ToString();    }

    void OnDestroy()
    {
        points.ChangeOfPoints -= ChangeText;
    }
}
