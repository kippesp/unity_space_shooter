using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBabyAsteroids : MonoBehaviour {
    public GameObject babyAsteroidOne;
    public GameObject babyAsteroidTwo;

    private Rigidbody rb;
    private GameController gc;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Access to the GameController is needed since stopping the game
        // in the Unity editor destroys any object (causing MammaAsteroids
        // prefabs to birth a few babys.)  We will check if the game is
        // over before continuing with the birther logic.
        GameObject go = GameObject.FindWithTag("GameController");
        gc = go.GetComponent<GameController>();
    }

	void OnDestroy() {

        // Don't spawn any babies if the game is over (or stopped in the
        // Unity editor)
        if (gc.isGameOver())
        {
            return;
        }

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
