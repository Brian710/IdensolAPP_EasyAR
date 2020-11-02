using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChangeMat : MonoBehaviour
{
    public ChangeMaterial ChgMat;//抓取scirpt
    public GameObject[] tagObjectAll;
    public GameObject[] tagObjectCourse03;
    public GameObject[] tagObjectCourse04;
    public GameObject[] tagObjectCourse05;
    public GameObject[] tagObjectCourse06;

    public GameObject[] tagObjectCourseOutline03;
    public GameObject[] tagObjectCourseOutline04;
    public GameObject[] tagObjectCourseOutline05;

    private void Start()
    {
        tagObjectAll = GameObject.FindGameObjectsWithTag("All");
        tagObjectCourse03 = GameObject.FindGameObjectsWithTag("Course03");
        tagObjectCourse04 = GameObject.FindGameObjectsWithTag("Course04");
        tagObjectCourse05 = GameObject.FindGameObjectsWithTag("Course05");
        tagObjectCourse06 = GameObject.FindGameObjectsWithTag("Course06");

        tagObjectCourseOutline03 = GameObject.FindGameObjectsWithTag("CourseOutLine03");
        tagObjectCourseOutline04 = GameObject.FindGameObjectsWithTag("CourseOutLine04");
        tagObjectCourseOutline05 = GameObject.FindGameObjectsWithTag("CourseOutLine05");
    }


    void EventChangeCourse03()
    {
        for (int i = 0; i < tagObjectAll.Length; i++)
        {
            tagObjectAll[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }

        for (int i = 0; i < tagObjectCourse04.Length; i++)
        {
            tagObjectCourse04[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }

        for (int i = 0; i < tagObjectCourse05.Length; i++)
        {
            tagObjectCourse05[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }




        for (int i = 0; i < tagObjectCourseOutline04.Length; i++)
        {
            tagObjectCourseOutline04[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }

        for (int i = 0; i < tagObjectCourseOutline05.Length; i++)
        {
            tagObjectCourseOutline05[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }
    }

    void EventChangeCourse04()//動畫04不同Tag換透明材質球
    {

        for (int i = 0; i < tagObjectAll.Length; i++)
        {
            tagObjectAll[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }

        for (int i = 0; i < tagObjectCourse03.Length; i++)
        {
            tagObjectCourse03[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }


        for (int i = 0; i < tagObjectCourseOutline03.Length; i++)
        {
            tagObjectCourseOutline03[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }
    }

    void EventChangeCourse05()
    {
        for (int i = 0; i < tagObjectAll.Length; i++)
        {
            tagObjectAll[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }

        for (int i = 0; i < tagObjectCourse04.Length; i++)
        {
            tagObjectCourse04[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }



        for (int i = 0; i < tagObjectCourseOutline04.Length; i++)
        {
            tagObjectCourseOutline04[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }
    }


    void EventChangeCourse06()
    {
        for (int i = 0; i < tagObjectAll.Length; i++)
        {
            tagObjectAll[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }

        for (int i = 0; i < tagObjectCourse03.Length; i++)
        {
            tagObjectCourse03[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }

        for (int i = 0; i < tagObjectCourse04.Length; i++)
        {
            tagObjectCourse04[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }




        for (int i = 0; i < tagObjectCourseOutline03.Length; i++)
        {
            tagObjectCourseOutline03[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }

        for (int i = 0; i < tagObjectCourseOutline04.Length; i++)
        {
            tagObjectCourseOutline04[i].GetComponent<ChangeMaterial>().ChangeWhaiteMat();
        }
    }

    void EventChangeOld()//換回原本材質球/////////////////////////////////////////////////
    {
        for (int i = 0; i < tagObjectAll.Length; i++)
        {
            tagObjectAll[i].GetComponent<ChangeMaterial>().ChangeOldMat();
        }




        for (int i = 0; i < tagObjectCourse03.Length; i++)
        {
            tagObjectCourse03[i].GetComponent<ChangeMaterial>().ChangeOldMat();
        }

        for (int i = 0; i < tagObjectCourseOutline03.Length; i++)
        {
            tagObjectCourseOutline03[i].GetComponent<ChangeMaterial>().ChangeOldMatOutline();
        }





        for (int i = 0; i < tagObjectCourse04.Length; i++)
        {
            tagObjectCourse04[i].GetComponent<ChangeMaterial>().ChangeOldMat();
        }
        for (int i = 0; i < tagObjectCourseOutline04.Length; i++)
        {
            tagObjectCourseOutline04[i].GetComponent<ChangeMaterial>().ChangeOldMatOutline();
        }



        for (int i = 0; i < tagObjectCourse05.Length; i++)
        {
            tagObjectCourse05[i].GetComponent<ChangeMaterial>().ChangeOldMat();
        }
        for (int i = 0; i < tagObjectCourseOutline05.Length; i++)
        {
            tagObjectCourseOutline05[i].GetComponent<ChangeMaterial>().ChangeOldMatOutline();
        }

    }
}
