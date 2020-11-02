using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * 
 * Accelerates its object in a fixed acceleration
 */

[RequireComponent(typeof(Mover))]
public class Accelerator : MonoBehaviour
{

    [Tooltip("Accelerate the speed to the object")]
    [SerializeField]
    float accelerator = 1f;
    float slow;
    Mover m;

    // Start is called before the first frame update
    void Start()
    {
        m = GetComponent<Mover>();
        slow = transform.position.x + 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= slow && m.GetSpeed() > 0)
        {
            m.AddSpeed(Time.deltaTime * accelerator);
        }

        if (transform.position.x >= -slow && m.GetSpeed() < 0)
        {
            m.AddSpeed(Time.deltaTime * -accelerator);
        }
    }
}
