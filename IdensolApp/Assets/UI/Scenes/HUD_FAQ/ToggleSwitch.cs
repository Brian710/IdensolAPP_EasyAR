using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSwitch : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    public Animator m_Animator;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    public void OnChangeValue()
    {
    bool onoffSwitch = gameObject.GetComponent<Toggle>().isOn;



        if(onoffSwitch)
        {
            on.SetActive(true);
            off.SetActive(false);
            m_Animator.Play("Open");
        }
        else
        {
            on.SetActive(false);
            off.SetActive(true);
            m_Animator.Play("Close");
        }


    }

}
