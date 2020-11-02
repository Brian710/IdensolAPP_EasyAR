using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColtroller : MonoBehaviour
{
    public float sensitivityX = 0.0001f;
    public float sensitivityY = 0.0001f;
    void update()
    {
        //單指控制攝像頭旋轉
        if (Input.touchCount == 1)
        {
            float rotationX = Input.GetAxis("Mouse X") * sensitivityX;
            float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
            transform.Rotate(-rotationY, rotationX, 0);

        }
        //雙指控制攝像頭移動
        if (Input.touchCount == 2)
        {
            transform.position += transform.forward * Time.deltaTime * 20;
        }
    }
}
