using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/**
 * 
 * This component moves its object left or right in a fixed speed
 */
public class Mover : MonoBehaviour
{
    [Tooltip("move object left and right in fixed speed")]
    [SerializeField]
    float speed = 1f;
    float stop;

    // add speed to speed property
    public void AddSpeed(float s) {
        speed += s;
    }

    //getter for property
    public float GetSpeed()
    {
        return speed;
    }


    // Start is called before the first frame update
    void Start()
    {
        stop = transform.position.x + 5f;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x >= stop) 
        {
            speed = 1f;
            speed = -speed;
        }

        if (transform.position.x <= -stop)
        {
            speed = -1f;
            speed = -speed;
        }

        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
