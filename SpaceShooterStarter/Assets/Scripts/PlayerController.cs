using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The boundary class is serializable in order to privide access
// to the public floats from within the Unity inspector.
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
    private AudioSource audioSource;

    // TODO: public float speed;
    public float tilt;
    public Boundary boundary;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            audioSource.Play();
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // TODO: Debug.Log("moveHorizontal: " + moveHorizontal);
        // TODO: Debug.Log("moveVertical: " + moveVertical);

        rb.velocity = movement;

        // Check we don't leave the viewing area
        if ((boundary.xMin != boundary.xMax) && (boundary.zMin != boundary.zMax))
        {
            rb.position = new Vector3(
                Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
                rb.position.y,
                Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax));
        }

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}