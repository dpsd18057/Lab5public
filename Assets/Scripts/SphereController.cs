using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{

    public float acc = 0.01f;
    public float jump = 10;
    public float forward = 10;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = new Vector3(0, jump, forward);
        }
    }

    void FixedUpdate()
    {

        rb.velocity += new Vector3(Input.GetAxis("Horizontal") * acc, 0, 0);


    }
}
