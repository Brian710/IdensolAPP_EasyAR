using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEvent : MonoBehaviour
{
    public GameObject Finish;
    public GameObject buttonMain;

    public void OnFinish()
    {
        gameObject.SetActive(false);
    }

    public void OpenFinish()
    {
        Finish.SetActive(true);
    }

    public void DestroyFinish()
    {
        Destroy(gameObject);
    }

    public void Course02Finish()
    {
        gameObject.SetActive(false);
        buttonMain.SetActive(true);
    }

}
