using UnityEngine;

public class DefaultPosition : MonoBehaviour
{
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    public void ResetToDefaultPosition()
    {
        transform.position = initialPosition;
    }
}
