using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class BoxEnemyInput : MonoBehaviour, IControl
{
    Enemy enemy;

    void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    public float GetVertical()
    {
        return enemy.vertical;
    }
}
