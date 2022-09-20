using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float vertical { get; private set; }

    [SerializeField] Transform ball;
    [SerializeField] float responseDelay;

    void Update()
    {
        var distance = Vector2.Distance(ball.position, transform.position);

        if (ball.position.y > transform.position.y)
        {
            if (distance <= 1)
                vertical = distance;
            else
                vertical = 1;
        }
        else
        {
            if (distance <= 1)
                vertical = -distance;
            else
                vertical = -1;
        }

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(responseDelay);
    }
}
