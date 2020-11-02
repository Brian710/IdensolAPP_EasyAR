using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebLink : MonoBehaviour
{
    public void OpenWeb()
    {
        Debug.Log("Web");
        Application.OpenURL("https://www.jcit.com.tw");
    }

    public void OpenYoutube()
    {
        Debug.Log("Youtube");
        Application.OpenURL("http://www.youtube.com");
    }

    public void toshintech()//官網
    {
        Debug.Log("toshintech");
        Application.OpenURL("http://www.toshintech.com");
    }

    public void idensol()//官網
    {
        Debug.Log("idensol");
        Application.OpenURL("http://www.idensol.com.de");
    }
    
    public void ContactUS()//聯絡我們
    {
        Debug.Log("聯絡我們");
        Application.OpenURL("https://www.toshintech.com/contact-tw/");
    }

    public void YoutubeDesign()//假牙設計連結
    {
        Application.OpenURL("https://www.youtube.com/playlist?list=PLDEIsIIW2mhvkMgYzxJ_wSrNZNsmY7opL");
    }

    public void YoutubeType()//假牙排版連結
    {
        Application.OpenURL("https://www.youtube.com/playlist?list=PLDEIsIIW2mhukP-mzeDBBWXilKPturY8V");
    }

    public void YoutubeStep02()//介面介紹
    {
        Application.OpenURL("https://www.youtube.com/playlist?list=PLDEIsIIW2mhvlLp1X-v1-nzwHYTi1BIse");
    }
}

