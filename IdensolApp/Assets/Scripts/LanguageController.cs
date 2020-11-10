using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageController : MonoBehaviour
{
    public Language Language;
    public void GetLanguage()
    {
        LanguageManager.Instance.language = Language;
        LanguageManager.Instance.OnLanguageChange();
    }
}
