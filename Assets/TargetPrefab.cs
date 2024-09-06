using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPrefab : MonoBehaviour
{
    public float movementRange = 50f;
    public float speed = 2f;

    private Vector3 startPosition;
    private float timeOffset;

    void Start()
    {
        startPosition = transform.position;
        timeOffset = Random.value * 100f;
    }

    void Update()
    {
        float time = Time.time * speed + timeOffset;

        // Generate random movement within the range
        float newPositionX = Mathf.PingPong(time, movementRange) - movementRange / 2;
        float newPositionY = Mathf.PingPong(time + 10f, movementRange) - movementRange / 2; 

        transform.position = startPosition + new Vector3(newPositionX, newPositionY, 0);
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject); // Destroys the GameObject when a collision occurs
    }

}
