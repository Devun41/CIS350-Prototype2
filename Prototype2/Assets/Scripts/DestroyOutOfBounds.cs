/*
 Devun Schneider
 Prototype 2
 Controls the destruction of the animal entities/gameObjects that exceed the play area
 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound = 20;
    public float bottomBound=-10;

    private HealthSystem healthSystemScript;
    public void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //if food goes OutOfBounds
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < bottomBound)
        {
            //grab the health system script on the health system panel object and call TakeDamage()
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();
            Destroy(gameObject);
        }
     
    }
}
