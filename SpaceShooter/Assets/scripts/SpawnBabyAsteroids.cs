using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBabyAsteroids : MonoBehaviour {
    public GameObject babyAsteroidOne;
    public GameObject babyAsteroidTwo;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void OnDestroy() {
        CapsuleCollider capsuleCollider = babyAsteroidOne.GetComponent<CapsuleCollider>();

        Vector3 spawnPositionOne = new Vector3(rb.position.x - capsuleCollider.radius, rb.position.y, rb.position.z);
        Vector3 spawnPositionTwo = new Vector3(rb.position.x + capsuleCollider.radius, rb.position.y, rb.position.z);

        Instantiate(babyAsteroidOne, spawnPositionOne, Quaternion.identity);
        Mover babyAsteroidOneMover = babyAsteroidOne.GetComponent<Mover>();
        babyAsteroidOneMover.angleDegrees = 10;

        Instantiate(babyAsteroidTwo, spawnPositionTwo, Quaternion.identity);
        Mover babyAsteroidTwoMover = babyAsteroidTwo.GetComponent<Mover>();
        babyAsteroidTwoMover.angleDegrees = -10;
	}
}
