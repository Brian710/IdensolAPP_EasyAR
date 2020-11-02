using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCourse : MonoBehaviour
{
    public GameObject buttonCourseGroup;//按鈕群組

    public GameObject uiMain;//主頁UI
    public GameObject uiCourse01;//操作面板說明
    public GameObject uiCourse02;//燈號說明
    public GameObject uiCourse03;//筒夾保養
    public GameObject uiCourse04;//換料盤
    public GameObject uiCourse05;//橡膠墊鑽孔
    public GameObject uiCourse06;//刀具庫位置

    public GameObject Course01;//操作面板說明
    public GameObject Course02;//燈號說明
    public GameObject Course03;//筒夾保養
    public GameObject Course04;//換料盤
    public GameObject Course05;//橡膠墊鑽孔
    public GameObject Course06;//刀具庫位置
    public GameObject LED;

    public GameObject CourseUi;//抓取UI物件動畫
    public Animator CourseUiAnimator;//UI動畫
    public GameObject CourseModle;//抓取所有動畫
    public Animator CourseAnimator;//動畫

    public TrackingTarget scriptTracking;

    public GameObject camereObject;//相機物件

    Transform povit;
    Vector3 povitOrgRot;

    private void Start()
    {
        CourseUiAnimator = CourseUi.GetComponent<Animator>();
        CourseAnimator = CourseModle.GetComponent<Animator>();

        povit = camereObject.transform;
        povitOrgRot = povit.localEulerAngles;
    }

    public void GotToCourse01()
    {
        Debug.Log("Course01");
        buttonCourseGroup.SetActive(false);
        uiMain.SetActive(false);

        uiCourse01.SetActive(true);
        Course01.SetActive(true);

        CourseAnimator.SetLayerWeight(0, 1);//Layer圖層權重
        CourseAnimator.SetLayerWeight(2, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(3, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(4, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(5, 0);//Layer圖層權重

        CourseAnimator.Play("1_01");
    }

    public void GotToCourse02()
    {
        LED.SetActive(false);
        Debug.Log("Course02");
        buttonCourseGroup.SetActive(false);
        Course02.SetActive(true);
        uiMain.SetActive(false);
        uiCourse02.SetActive(true);
    }

    public void GotToCourse03()
    {
        Debug.Log("Course03");
        buttonCourseGroup.SetActive(false);
        uiMain.SetActive(false);

        uiCourse03.SetActive(true);
        Course03.SetActive(true);

        CourseAnimator.SetLayerWeight(0, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(2, 1);//Layer圖層權重
        CourseAnimator.SetLayerWeight(3, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(4, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(5, 0);//Layer圖層權重

        CourseAnimator.Play("3_01");
    }

    public void GotToCourse04()
    {
        Debug.Log("Course04");
        buttonCourseGroup.SetActive(false);
        uiMain.SetActive(false);

        uiCourse04.SetActive(true);

        CourseAnimator.SetLayerWeight(0, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(2, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(3, 1);//Layer圖層權重
        CourseAnimator.SetLayerWeight(4, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(5, 0);//Layer圖層權重

        CourseAnimator.Play("4_01");
    }

    public void GotToCourse05()
    {
        Debug.Log("Course05");
        buttonCourseGroup.SetActive(false);
        uiMain.SetActive(false);

        uiCourse05.SetActive(true);
        Course05.SetActive(true);

        CourseAnimator.SetLayerWeight(0, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(2, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(3, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(4, 1);//Layer圖層權重
        CourseAnimator.SetLayerWeight(5, 0);//Layer圖層權重

        CourseAnimator.Play("5_01");
    }

    public void GotToCourse06()
    {
        Debug.Log("Course06");
        buttonCourseGroup.SetActive(false);
        uiMain.SetActive(false);

        uiCourse06.SetActive(true);
        Course06.SetActive(true);

        CourseAnimator.SetLayerWeight(0, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(2, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(3, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(4, 0);//Layer圖層權重
        CourseAnimator.SetLayerWeight(5, 1);//Layer圖層權重

        CourseAnimator.Play("6_01");
    }

    public void GotToMain()
    {
        Debug.Log("BackMain");
        //povit.localEulerAngles = povitOrgRot;
    }
}
