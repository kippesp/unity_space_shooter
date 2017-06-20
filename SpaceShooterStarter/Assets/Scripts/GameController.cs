using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject hazard;
    public Vector3 spawnValues;

    public float minWaitPerHazard;
    public float maxWaitPerHazard;

    private float nextHazardTime;

    private void Start()
    {
        nextHazardTime = Time.time;
    }

    private void FixedUpdate()
    {
#if false
        if (nextHazardTime <= Time.time)
        {
            nextHazardTime = Time.time + Random.Range(minWaitPerHazard, maxWaitPerHazard);
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;

            Instantiate(hazard, spawnPosition, spawnRotation);
        }
#endif
    }
}