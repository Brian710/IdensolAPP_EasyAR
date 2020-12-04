using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallInfo : MonoBehaviour
{

    public GameObject info;
    public GameObject parentGameobject;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void CreateInfo()
    {
        Instantiate(info, transform);
        StartCoroutine(DelayInfo());
        parentGameobject = GameObject.Find("FixDelay");
        parentGameobject.SetActive(false);
    }

    private IEnumerator DelayInfo()
    {
        yield return new WaitForSeconds(0.01f);
        parentGameobject.SetActive(true);
        
    }
}