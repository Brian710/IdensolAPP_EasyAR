using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCoursePosition : MonoBehaviour
{
    public Vector3 Position;

    private Language Language;
    void Start()
    {
        Language = LanguageManager.Instance.language;
        Set(Language);
    }
    private void Set(Language language)
    {
        if(language == Language.English)
        {
            GetComponent<Transform>().position = Position;
        }
    }
}
