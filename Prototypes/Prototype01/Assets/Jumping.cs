using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
   public Rigidbody rb;
    private void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
    }
}
