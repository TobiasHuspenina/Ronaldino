using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    public GameObject CheckBox1;
    public GameObject CheckBox2;

    private bool isCollidingWithCheckBox1;
    private bool isCollidingWithCheckBox2;
    private Vector3 defaultPosition;

    void Start()
    {
        // Uložení výchozí pozice objektu
        defaultPosition = transform.position;
    }

    void Update()
    {
        // Reset the collision flags at the beginning of each frame
        isCollidingWithCheckBox1 = false;
        isCollidingWithCheckBox2 = false;
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object collides with CheckBox1
        if (other.gameObject == CheckBox1)
        {
            isCollidingWithCheckBox1 = true;
        }

        // Check if the object collides with CheckBox2
        if (other.gameObject == CheckBox2)
        {
            isCollidingWithCheckBox2 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the object stops colliding with CheckBox1
        if (other.gameObject == CheckBox1)
        {
            isCollidingWithCheckBox1 = false;
        }

        // Check if the object stops colliding with CheckBox2
        if (other.gameObject == CheckBox2)
        {
            isCollidingWithCheckBox2 = false;
        }
    }

    void LateUpdate()
    {
        // If the object is not colliding with CheckBox1 and CheckBox2, do something
        if (!isCollidingWithCheckBox1 && !isCollidingWithCheckBox2)
        {
            // Do something here
            transform.position = defaultPosition;

        }
    }

    void ReturnToDefaultPosition()
    {
        // Nastavení pozice objektu na výchozí pozici
        transform.position = defaultPosition;
    }
}
