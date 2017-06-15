using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBabyAsteroids : MonoBehaviour {
    public GameObject smallHazard;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void OnDestroy() {
        Vector3 spawnPosition = new Vector3(rb.position.x, rb.position.y, rb.position.z);

        Instantiate(smallHazard, spawnPosition, Quaternion.identity);
	}
}
