using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR : MonoBehaviour
{
    public GameObject modleObject;
    public GameObject arObject;
    public GameObject idensol;
    public GameObject arInput;
    public GameObject modleInput;
    public GameObject[] arButton;
    public GameObject[] modleButton;
    public GameObject modleCamera;
    public GameObject arCamera;
    public GameObject detAR;

    Camera mCamera;
    AudioListener mCameraLis;


    // Start is called before the first frame update
    void Start()
    {
        mCamera = modleCamera.GetComponent<Camera>();
        mCameraLis = modleCamera.GetComponent<AudioListener>();
    }

    public void ChangeToAR()
    {
        Renderer[] rs = idensol.GetComponentsInChildren<Renderer>(true);
        foreach (Renderer r in rs)
        {
            r.enabled = false;
        }
        Collider[] cs = idensol.GetComponentsInChildren<Collider>(true);
        foreach (Collider c in cs)
        {
            c.enabled = false;
        }


        Instantiate(arObject);
        arInput = GameObject.Find("Ground Plane Stage");
        idensol.transform.parent = arInput.transform;

        modleObject.SetActive(false);
        //modleCamera.SetActive(false);
        mCamera.enabled = false;
        mCameraLis.enabled = false;


        for (int i = 0; i < modleButton.Length; i++)
        {
            modleButton[i].SetActive(true);
        }

        for (int i = 0; i < arButton.Length; i++)
        {
            arButton[i].SetActive(false);
        }



    }

    public void ChangeToModle()
    {
        Renderer[] rs = idensol.GetComponentsInChildren<Renderer>(true);
        foreach (Renderer r in rs)
        {
            r.enabled = true;
        }
        Collider[] cs = idensol.GetComponentsInChildren<Collider>(true);
        foreach (Collider c in cs)
        {
            c.enabled = true;
        }



        modleObject.SetActive(true);
        //modleCamera.SetActive(true);
        mCamera.enabled = true;
        mCameraLis.enabled = true;

        idensol.transform.parent = modleInput.transform;

        idensol.transform.position = new Vector3(0, 0, 0);
        idensol.transform.localEulerAngles = new Vector3(0, 0, 0);

        for (int i = 0; i < modleButton.Length; i++)
        {
            modleButton[i].SetActive(false);
        }

        for (int i = 0; i < arButton.Length; i++)
        {
            arButton[i].SetActive(true);
        }

        detAR = GameObject.Find("AR(Clone)");
        Destroy(detAR);
    }


}
