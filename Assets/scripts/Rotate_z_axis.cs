using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * 
 * This component rotate its object right on z-axis in a fixed speed
 */
public class Rotate_z_axis : MonoBehaviour
{
    [Tooltip("rotate object right on z-axis")]
    [SerializeField]
    float rotate_speed = 90f;
 
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0, 0, rotate_speed * Time.deltaTime);
    }
}
