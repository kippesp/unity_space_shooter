using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    private Rigidbody rb;

    public float speed;
    public float angleDegrees;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        float angleRadians = Mathf.Deg2Rad * angleDegrees;

        rb.velocity = new Vector3(
            -speed * Mathf.Sin(angleRadians),
            0,
            speed * Mathf.Cos(angleRadians));
//        rb.velocity = new Vector3(1, 0, 1.7f).normalized * speed;
//l        transform.Rotate(transform.forward * speed;
        // ??? angle
    }
}
