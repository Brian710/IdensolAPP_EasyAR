using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARModelShow : MonoBehaviour
{

    public GameObject modelTarget;
    public GameObject popreal;
    public GameObject teeth;

    Animator m_popreal;
    Animator m_teeth;

    // Start is called before the first frame update
    void Start()
    {
        m_popreal = popreal.GetComponent<Animator>();
        m_teeth = teeth.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("X"+ modelTarget.transform.localEulerAngles.x + "        Y"+ modelTarget.transform.localEulerAngles.y);


        if (modelTarget.transform.localEulerAngles.x <= 330f && modelTarget.transform.localEulerAngles.x >= 210f)
        {
            m_teeth.Play("On");
        }
        else
        {
            m_teeth.Play("Off");
        }


        if (modelTarget.transform.localEulerAngles.y <= 270 && modelTarget.transform.localEulerAngles.x >= 300f && modelTarget.transform.localEulerAngles.x <= 360f || modelTarget.transform.localEulerAngles.x >= 0f && modelTarget.transform.localEulerAngles.x <= 60f)
        {
            m_popreal.Play("On");
        }
        else
        {
            m_popreal.Play("Off");
        }
    }
}
