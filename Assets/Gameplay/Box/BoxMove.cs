using UnityEngine;

public class BoxMove : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float limitY = 4;

    IControl control;

    void Awake()
    {
        control = GetComponent<IControl>();
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x,
            Mathf.Clamp(transform.position.y + control.GetVertical() * speed * Time.deltaTime, -limitY, limitY));
    }
}
