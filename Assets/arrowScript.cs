using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowScript : MonoBehaviour
{
    private float arrowSpeed = 1;
    public Rigidbody2D arrowRigidBody;
    private bool inMotion = false;
    // Start is called before the first frame update
    void Start()
    {
        arrowRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // rotate the arrow while in bow
        if (inMotion == false) {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePosition - transform.position);
        }

        // arrow is fired
        if ((inMotion == false) && (Input.GetMouseButtonDown(0))) {
            inMotion = true;
            Vector2 direction = mousePosition - transform.position;
            direction.Normalize();
            arrowRigidBody.velocity = direction * arrowSpeed;
            transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePosition - transform.position);
        }
        
    }
}
