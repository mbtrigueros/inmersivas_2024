using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoyancy : MonoBehaviour
{
    public float buoyancyForce = 10f; // Strength of the buoyancy
    public float waterLevel = 0f; // Water level height (set this based on your scene)

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Calculate the distance from the water level
        float distanceToWater = transform.position.y - waterLevel;

        // If the character is below the water level, apply an upward force
        if (distanceToWater < 0)
        {
            rb.AddForce(Vector3.up * buoyancyForce * Mathf.Abs(distanceToWater));
        }
    }
}
