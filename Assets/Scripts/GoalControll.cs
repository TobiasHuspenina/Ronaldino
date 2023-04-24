using UnityEngine;

public class GoalControll : MonoBehaviour
{
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Mic")
        {
            Debug.Log("Object with tag 'Mic' touched the collider.");

        }
    }
}
