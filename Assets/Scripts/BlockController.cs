using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private Vector3 initialMousePosition;
    private float rotationSpeed = 3.0f; // Adjust this value to control rotation speed

    private void OnMouseDown()
    {
        initialMousePosition = Input.mousePosition;
    }

    private void OnMouseDrag()
    {
        // Calculate the difference between the current mouse position and the initial position
        Vector3 mouseDelta = Input.mousePosition - initialMousePosition;

        transform.Rotate(Vector3.back, -mouseDelta.x * rotationSpeed, Space.Self);

        initialMousePosition = Input.mousePosition;
    }
}

//add namespaces
//relative and global coordinates
