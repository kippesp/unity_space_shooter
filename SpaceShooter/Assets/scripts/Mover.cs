using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    private Rigidbody rb;
    private GameController gc;

    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        GameObject go = GameObject.FindWithTag("GameController");
        gc = go.GetComponent<GameController>();

        rb.velocity = transform.forward * (speed - gc.getWavesCleared());
    }
}
