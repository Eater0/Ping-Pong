using UnityEngine;

[RequireComponent(typeof(BallInput))]
public class BallMove : MonoBehaviour
{
    [SerializeField] int speedX;
    [SerializeField] int speedY;

    Rigidbody2D rigidbody2d;

    void Awake()
    {
        BallInput.Reflection += Reflection;

        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        int value = Random.Range(0, 2);

        if (value == 0)
            rigidbody2d.AddForce(new Vector2(-speedX, speedY));
        else
            rigidbody2d.AddForce(new Vector2(speedX, speedY));
    }

    void Reflection(Vector2 lastVelocity, Collision2D collision)
    {
        float speed = lastVelocity.magnitude;
        var direction = Vector2.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rigidbody2d.velocity = direction * speed;
    }

    void OnDestroy()
    {
        BallInput.Reflection -= Reflection;
    }
}
