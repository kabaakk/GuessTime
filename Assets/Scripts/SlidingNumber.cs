using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingNumber : MonoBehaviour
{
    public float downwardForce;
    public Transform number;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * downwardForce);

        if (number.position.y < 200)
        {
            transform.position = new Vector3(360, 1900, 0);
        }
    }
}
