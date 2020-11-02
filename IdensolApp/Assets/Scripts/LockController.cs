﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockController : MonoBehaviour
{

    public InputField userPassWordUI;
    public string userPassWord;
    public string correctPassWord;
    public Text hintMessage;
    public Button resetButton;
    public Button enterButton;
    public GameObject errorImage;
    private Animator errorAnimator;


    // Start is called before the first frame update
    void Start()
    {
       correctPassWord = "24828254";
        errorAnimator = errorImage.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetPassWord()
    {
        userPassWordUI.text = "";
        hintMessage.text = "";
    }
    public void CheckPassword()
    {
        userPassWord = userPassWordUI.text;
        
        if (correctPassWord == userPassWord)
        {
            hintMessage.text= "登入中...";
            errorImage.SetActive(false);
            SceneManager.LoadScene(1);

        }
        else
        {
            errorImage.SetActive(true);
            errorAnimator.SetTrigger("Start");
            userPassWordUI.text = "";

        }
    }
}