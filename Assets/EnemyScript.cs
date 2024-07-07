using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public static int enemyCount = 0;
    public GameObject arrowSprite;
    public GameObject bowSprite;
    private Vector3 arrowStartingPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        arrowStartingPosition = arrowSprite.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Awake()
    {
        enemyCount++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Arrow")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("Enemies Count:" + enemyCount);
            enemyCount--;

            if (enemyCount > 0) {
                Debug.Log("Arrow Sprite Starting Position2: " + arrowStartingPosition);
                Instantiate(arrowSprite, arrowStartingPosition, bowSprite.transform.rotation);
            }
        }   
    }
}
