using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class StartOfTheRound : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    void Awake()
    {
        BallOutOfBounds.TheBallIsOutOfBounds += BallReset;
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void BallReset()
    {
        transform.position = Vector2.zero;
        rigidbody2d.velocity = -rigidbody2d.velocity;
    }

    void OnDestroy()
    {
        BallOutOfBounds.TheBallIsOutOfBounds -= BallReset;
    }
}
