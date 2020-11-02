using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationConstrain : MonoBehaviour
{
    public float speed = 1.2f;
    public float hiSpeed = 5f;

    //public Vector2 Y_axis = new Vector2(60, 300);
    public Vector2 X_axis = new Vector2(60, 330);

    void OnMouseDrag()
    {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        Vector3 rotate = new Vector3(v, -h, 0);
        if (Input.GetMouseButton(0))
        {
            rotate *= hiSpeed;
        }
        else
        {
            rotate *= speed;
        }

        transform.Rotate(rotate);
        var euler = transform.rotation.eulerAngles;

        if (euler.x < X_axis.y && euler.x >= 180)
        {
            euler.x = X_axis.y - 360;
        }
        else if (euler.x > X_axis.x && euler.x <= 180)
        {
            euler.x = X_axis.x;
        }

        //if (euler.y < Y_axis.y && euler.y >= 180)
        //{
        //    euler.y = Y_axis.y - 360;
        //}
        //else if (euler.y > Y_axis.x && euler.y <= 180)
        //{
        //    euler.y = Y_axis.x;
        //}

        euler.z = 0;

        transform.rotation = Quaternion.Euler(euler);
    }
}
