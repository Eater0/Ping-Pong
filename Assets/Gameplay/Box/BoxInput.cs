using UnityEngine;

public class BoxInput : MonoBehaviour, IControl
{
    float vertical;

    private void Update()
    {
        vertical = Input.GetAxis("Vertical");
    }

    public float GetVertical()
    {
        return vertical;
    }
}
