using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFAQAnimator : MonoBehaviour
{
    public Animator Animator;
    public RuntimeAnimatorController AnimatorController;

    private Language Language;
   
    void Start()
    {
        Language = LanguageManager.Instance.language;
        Set(Language);
    }

    private void Set(Language language)
    {
        if(AnimatorController != null)
        {
            if (language == Language.English)
            {
                Animator.runtimeAnimatorController = AnimatorController;
            }
        }
    }
}
