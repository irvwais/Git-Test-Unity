using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script Written by Irv Wais

public class BoxBehaviour : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10f;

    /// <summary>
    /// OnMouseDrag is called when the user has clicked on a GUIElement or Collider
    /// and is still holding down the mouse.
    /// </summary>
    void OnMouseDrag()
    {
        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Mathf.Deg2Rad;
    
        // transform.RotateAround(Vector3.up, -rotationX);
        // transform.RotateAround(Vector3.right, -rotationY);
        
        transform.Rotate(Vector3.up, -rotationX, Space.Self);
        transform.Rotate(Vector3.right, -rotationY, Space.Self);
    }
}
