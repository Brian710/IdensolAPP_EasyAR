using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARLoadingClose : MonoBehaviour
{
    public GameObject arLoading;

    public void Close()
    {
        arLoading = GameObject.Find("AR_Loading");
        arLoading.SetActive(false);
    }
}
