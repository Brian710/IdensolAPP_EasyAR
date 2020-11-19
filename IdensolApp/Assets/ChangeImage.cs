using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    [SerializeField] private Image OrignalImage;
    [SerializeField] private Sprite OrignalSprite;

    [SerializeField] private Sprite TargetSprite_TC;
    [SerializeField] private Sprite TargetSprite_SC;
    [SerializeField] private Sprite TargetSprite_EN;
    public void Start()
    {
        //OrignalImage.sprite = OrignalSprite;
    }
    public void ChangeTargetImage()
    {
        OrignalSprite = OrignalImage.sprite;
        ChangeSpriteLanguage(LanguageManager.Instance.language);
    }
    private void ChangeSpriteLanguage(Language language)
    {
        switch (language)
        {
            case Language.TraditionalChinese:
                OrignalImage.sprite = TargetSprite_TC;
                break;
            case Language.SimplifiedChinese:
                OrignalImage.sprite = TargetSprite_SC;
                break;
            case Language.English:
                OrignalImage.sprite = TargetSprite_EN;
                break;
        }
    }
}
