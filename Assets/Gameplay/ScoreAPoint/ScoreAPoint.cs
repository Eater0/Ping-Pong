using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ScoreAPoint : MonoBehaviour
{
    [SerializeField] Points box;

    void OnTriggerEnter2D()
    {
        box.AddPoint();
    }
}
