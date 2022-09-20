using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallInput : MonoBehaviour
{
    public static event Action<Vector2, Collision2D> Reflection;

    Rigidbody2D rigidbody2d;
    Vector2 lastVelocity;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        lastVelocity = rigidbody2d.velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Reflection(lastVelocity, collision);
    }
}
