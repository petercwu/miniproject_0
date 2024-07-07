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
            Destroy(gameObject);
            enemyCount--;

            // reload the bow if there are still enemies
            if (enemyCount > 0) {
                Instantiate(arrowSprite, arrowStartingPosition, bowSprite.transform.rotation);
            }

            Destroy(collision.gameObject);
        }   
    }
}
