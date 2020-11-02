using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] originalMat;
    public Material white;
    Renderer renderer;
    Material oldMat;
    public GameObject whiteObject;


    // Start is called before the first frame update
    void Start()
    {
        //尋找場景中物件"XXX" 取出材質球到white
        whiteObject = GameObject.Find("XXX");
        Renderer A;
        Material B;
        A = whiteObject.GetComponent<Renderer>();
        B = A.material;
        white = B;

        //先取出陣列原本材質球
        renderer = gameObject.GetComponent<Renderer>();
        Material[] mats = renderer.materials;
        originalMat = mats;
    }
    //執行陣列換透明材質
    public void ChangeWhaiteMat()
    {
        renderer = gameObject.GetComponent<Renderer>();
        Material[] mats = renderer.materials;

        for (int i = 0; i < mats.Length; i++)
        {
            mats[i] = white;
            renderer.materials = mats;
        }
    }


    //執行陣列換回原本材質
    public void ChangeOldMat()
    {
        renderer = gameObject.GetComponent<Renderer>();
        Material[] mats = renderer.materials;


        for (int i = 0; i < mats.Length; i++)
        {
            mats[i] = originalMat[i];
            renderer.materials = mats;
        }
    }

    public void ChangeOldMatOutline()
    {

        GetComponent<Outline>().enabled = false;

        renderer = gameObject.GetComponent<Renderer>();
        Material[] mats = renderer.materials;

        for (int i = 0; i < mats.Length; i++)
        {
            mats[i] = originalMat[i];
            renderer.materials = mats;
        }
    }
}
