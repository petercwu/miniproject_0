using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowAngleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePosition - transform.position);
    }
}
