using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    public enum Language { TraditionalChinese, SimplifiedChinese, English };
    public Language language;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
