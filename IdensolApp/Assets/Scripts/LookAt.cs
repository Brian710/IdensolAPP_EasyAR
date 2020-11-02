using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform modelCamera;
    public Transform arCamera;

    public GameObject button01;
    public GameObject button02;
    public GameObject button03;
    public GameObject button04;
    public GameObject button05;
    public GameObject button06;
    public GameObject UI02;

    Animator m_b1;
    Animator m_b2;
    Animator m_b3;
    Animator m_b4;
    Animator m_b5;
    Animator m_b6;

    public Transform now;
    // Start is called before the first frame update
    void Start()
    {
        now = modelCamera;

        m_b1 = button01.GetComponent<Animator>();
        m_b2 = button02.GetComponent<Animator>();
        m_b3 = button03.GetComponent<Animator>();
        m_b4 = button04.GetComponent<Animator>();
        m_b5 = button05.GetComponent<Animator>();
        m_b6 = button06.GetComponent<Animator>();
    }

    public void ARChange()
    {
        arCamera = GameObject.Find("ARCamera").transform;
        now = arCamera;
    }
    public void DelatARChange()
    {

    }

    public void ModelChange()
    {
        now = modelCamera;
    }

    // Update is called once per frame
    void Update()
    {
        if (now == modelCamera)
        {
            if (button01.transform.eulerAngles.y > 40 && button01.transform.eulerAngles.y < 265)
            {
                m_b1.SetBool("Show", true);
            }
            else
            {
                m_b1.SetBool("Show", false);
            }

            if (button02.transform.eulerAngles.y > 55 && button02.transform.eulerAngles.y < 290)
            {
                m_b2.SetBool("Show", true);
            }
            else
            {
                m_b2.SetBool("Show", false);
            }

            if (button03.transform.eulerAngles.y > 120 && button03.transform.eulerAngles.y < 320)
            {
                m_b3.SetBool("Show", true);
                m_b4.SetBool("Show", true);
            }
            else
            {
                m_b3.SetBool("Show", false);
                m_b4.SetBool("Show", false);
            }

            if (button05.transform.eulerAngles.y > 80 && button05.transform.eulerAngles.y < 280)
            {
                m_b5.SetBool("Show", true);
                m_b6.SetBool("Show", true);
            }
            else
            {
                m_b5.SetBool("Show", false);
                m_b6.SetBool("Show", false);
            }
        }
        else
        {
            m_b1.SetBool("Show", true);
            m_b2.SetBool("Show", true);
            m_b3.SetBool("Show", true);
            m_b4.SetBool("Show", true);
            m_b5.SetBool("Show", true);
            m_b6.SetBool("Show", true);
        }

        button01.transform.LookAt(now);
        button02.transform.LookAt(now);
        button03.transform.LookAt(now);
        button04.transform.LookAt(now);
        button05.transform.LookAt(now);
        button06.transform.LookAt(now);
        UI02.transform.LookAt(now);


    }
}
