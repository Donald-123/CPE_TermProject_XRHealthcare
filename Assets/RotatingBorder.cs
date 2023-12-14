using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPivot : MonoBehaviour
{
    public Transform pivot; // Assign the pivot point in the Unity Editor
    public float rotationSpeed = 45f; // Adjust the rotation speed as needed

    void Update()
    {
        // Check if a pivot point is assigned
        if (pivot != null)
        {
            // Calculate the rotation angle based on the rotation speed and time
            float angle = rotationSpeed * Time.deltaTime;

            // Create a rotation quaternion around the Z-axis
            Quaternion rotation = Quaternion.Euler(0, 0, angle);

            // Calculate the new position relative to the pivot
            Vector3 newPosition = rotation * (transform.position - pivot.position) + pivot.position;

            // Apply the new position
            transform.position = newPosition;

            // Rotate the object around the Z-axis
            transform.Rotate(0, 0, angle);
        }
        else
        {
            Debug.LogError("Please assign a pivot point in the Unity Editor.");
        }
    }
}