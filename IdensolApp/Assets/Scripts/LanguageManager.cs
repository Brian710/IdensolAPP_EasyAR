using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MinYan.Lang;
using System;


public enum Language
{
    TraditionalChinese = 0,
    SimplifiedChinese = 1,
    English = 2,
};
public class LanguageManager : MonoBehaviour
{
    public Language language;

    [SerializeField] private muitiLang multiL;
    public muitiLang MultiLang => multiL;
    public void Start()
    {
        if (multiL == null)  multiL = Resources.Load<muitiLang>("ExcelFiles/muitiLang");
        DontDestroyOnLoad(this.gameObject);
        OnLanguageChange();
    }
    #region singleton
    /// <summary>
    /// The instance.
    /// </summary>
    public static LanguageManager Instance;
    protected virtual void SingletonInit()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this);
    }
    #endregion
    protected virtual void Awake()
    {
        SingletonInit();
    }
    public void OnLanguageChange()
    {
        foreach (updatingMultiText upText in FindObjectsOfType<updatingMultiText>())
        {
            upText.Set();
        }
        foreach (updatingMultiImg upImg in FindObjectsOfType<updatingMultiImg>())
        {
            upImg.Set();
        }
    }
}
