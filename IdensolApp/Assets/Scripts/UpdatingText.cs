using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatingText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LanguageManager.Instance.OnLanguageChange();
    }
}
