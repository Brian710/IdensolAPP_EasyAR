using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TopBar : MonoBehaviour
{
    public float changeScenesTime = 0.1f;

    public void ToSpetHome()
    {
        StartCoroutine(BackgroundHome());
    }
    public void ToSpet1()
    {
        StartCoroutine(Background1());
    }
    public void ToSpet2()
    {
        StartCoroutine(Background2());
    }
    public void ToSpet3()
    {
        StartCoroutine(Background3());
    }
    public void ToSpet4()
    {
        StartCoroutine(Background4());
    }
    public void ARmodel()
    {
        StartCoroutine(AR());
    }


    IEnumerator BackgroundHome()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(1);
    }
    IEnumerator Background1()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(2);
    }
    IEnumerator Background2()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(3);
    }
    IEnumerator Background3()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(4);
    }
    IEnumerator Background4()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(5);
    }
    IEnumerator AR()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(6);
    }
}
