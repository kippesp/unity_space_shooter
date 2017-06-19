using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    private Rigidbody rb;
    private GameController gc;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        GameObject go = GameObject.FindWithTag("GameController");
        gc = go.GetComponent<GameController>();
    }
}
