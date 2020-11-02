using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

/**
 * 
 * reSize object  on x and y -axis
 */
public class ReSize : MonoBehaviour
{
    [Tooltip("reSize object  on x and y -axis")]
    [SerializeField]
    float resize = 0.3f;
    float start_size_x;
    float start_size_y;
    // Start is called before the first frame update
    void Start()
    {
        start_size_x = transform.localScale.x;
        start_size_y = transform.localScale.y;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < 0.3 && transform.localScale.y < 0.3)
        {
            float new_size = resize * Time.deltaTime;
            transform.localScale += new Vector3(new_size, new_size, 0);
        }
        else 
        {
            transform.localScale = new Vector3(start_size_x, start_size_y, 0);
        }
    }
}
