using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseEvent : MonoBehaviour
{
    public GameObject ButtonCourse;
    public GameObject LED;
    public GameObject modle;
    Animator m_Modle;
    public GameObject uiCourse;
    public GameObject uiPage01;
    public GameObject uiPage02;
    public GameObject uiPage03;
    public GameObject uiPage04;

    public GameObject Button;

    public void ObjectEnd()
    {
        LED.SetActive(true);
        ButtonCourse.SetActive(true);
        gameObject.SetActive(false);
        
    }

    public void CoruseFinish()
    {
        m_Modle = modle.GetComponent<Animator>();
        m_Modle.SetTrigger("Main");
        LED.SetActive(true);
        ButtonCourse.SetActive(true);
        uiCourse.SetActive(false);
        gameObject.SetActive(false);
        Button.SetActive(true);
    }

    public void Course01Finish()
    {
        if(uiPage01.active == true)
        {
            Animator m_uiPage01 = uiPage01.GetComponent<Animator>();
            m_uiPage01.SetTrigger("Back");
            gameObject.SetActive(false);
        }
        if(uiPage02.active == true)
        {
            Animator m_uiPage02 = uiPage02.GetComponent<Animator>();
            m_uiPage02.SetTrigger("Back");
            gameObject.SetActive(false);
        }
        if (uiPage03.active == true)
        {
            Animator m_uiPage03 = uiPage03.GetComponent<Animator>();
            m_uiPage03.SetTrigger("Back");
            gameObject.SetActive(false);
        }
        if (uiPage04.active == true)
        {
            Animator m_uiPage04 = uiPage04.GetComponent<Animator>();
            m_uiPage04.SetTrigger("Back");
            gameObject.SetActive(false);
        }
    }

}
