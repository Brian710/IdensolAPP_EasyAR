using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCoursePosition : MonoBehaviour
{
    public float Position_X;
    public float Position_Y;
    public float Position_Z;

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
            GetComponent<Transform>().position = new Vector3(Position_X, Position_Y, Position_Z);
        }
    }
}
