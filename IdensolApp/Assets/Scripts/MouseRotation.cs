using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    float rotSpeed = 10;
    public float rotationsX;
    public float rotationsY;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        rotationsX = transform.eulerAngles.x;
        transform.RotateAround(Vector3.right, rotY);

        rotationsY = transform.eulerAngles.y;
        transform.RotateAround(Vector3.up, -rotX);

    }

}
