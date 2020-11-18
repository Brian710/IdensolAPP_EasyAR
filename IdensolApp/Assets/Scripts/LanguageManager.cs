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
public enum LanguageFont
{
    Bold = 0,
    Medium = 1,
};
public class LanguageManager : MonoBehaviour
{
    public Language language;
    public Font languageFont_TC_Medium;
    public Font languageFont_TC_Bold;
    public Font languageFont_SC_Medium;
    public Font languageFont_SC_Bold;
    public Font languageFont_EN_Regular;
    public Font languageFont_EN_Bold;

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
        foreach (updatingMultiSprite upSprite in FindObjectsOfType<updatingMultiSprite>())
        {
            upSprite.Set();
        }
    }
}
