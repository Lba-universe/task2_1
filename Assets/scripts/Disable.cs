using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * disable component on mouse click
 */
public class Disable : MonoBehaviour
{
    SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            sp.enabled = !sp.enabled;
    }
}
