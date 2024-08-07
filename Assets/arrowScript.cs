using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowScript : MonoBehaviour
{
    public float arrowSpeed;
    public Rigidbody2D arrowRigidBody;
    private bool inMotion = false;
    public logicScript logic;
    public bool gameSession;
    // Start is called before the first frame update
    void Start()
    {
        arrowRigidBody = GetComponent<Rigidbody2D>();
        gameSession = true;
    }

    // Update is called once per frame
    void Update()
    { 
        if (gameSession == true) {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // rotate the arrow while in bow
            if (inMotion == false) {
                Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, mousePosition - transform.position);
                transform.rotation = targetRotation * Quaternion.Euler(0, 0, 90);
            }

            // arrow is fired
            if ((inMotion == false) && (Input.GetMouseButtonDown(0))) {
                inMotion = true;
                Vector2 direction = mousePosition - transform.position;
                direction.Normalize();
                arrowRigidBody.velocity = direction * arrowSpeed;
                Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, mousePosition - transform.position);
                transform.rotation = targetRotation * Quaternion.Euler(0, 0, 90);
                
            }

            // horizonal boundary
            // if ((transform.position.x > 2.76) || (transform.position.x < -1.8)) {
            //     gameSession = false;
            //     logic.gameOver();
            // }

            Vector3 screenPosition = Camera.main.WorldToViewportPoint(transform.position);
            if (screenPosition.x < 0 || screenPosition.x > 1 || screenPosition.y < 0 || screenPosition.y > 1) {
                gameSession = false;
                logic.gameOver();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 currentDirection = transform.right;
        
        // reflect the direction based on the collision normal
        Vector2 reflectedDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);
        float angle = Mathf.Atan2(reflectedDirection.y, reflectedDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

}
