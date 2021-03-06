﻿using UnityEngine;
using UnityEngine.UI;

namespace MinYan.Lang
{
    [RequireComponent(typeof(Text))]
    public class updatingMultiText:MonoBehaviour
    {
        public string multiId;
        public string currentString;
        public int FontSize_CH;
        public int FontSize_EN;

        private Text multiText;
        public LanguageFont languageFont;
        private Font _languagefont;
        

        private void Awake() => multiText = GetComponent<Text>();
        public void Set()
        {
            if (multiText == null)
            {
                Debug.LogWarning("doesn't have text component");
                return;
            }
            if (multiId == "")
            {
                Debug.LogWarning("multiId is null");
                return;
            }
            multiText.text = UpdateLanguage(LanguageManager.Instance.language, LanguageManager.Instance.MultiLang);
            multiText.font = UpdateTextFont(LanguageManager.Instance.language, languageFont);
        }
        public string UpdateLanguage(Language language, muitiLang muiti)
        {
            for (int i = 0; i < muiti.dataArray.Length; i++)
            {
                if (multiId == muiti.dataArray[i].Id)
                {
                    switch (language)
                    {
                        case Language.TraditionalChinese:
                            currentString = muiti.dataArray[i].TraditionalChinese;
                            break;
                        case Language.SimplifiedChinese:
                            currentString = muiti.dataArray[i].SimplifiedChinese;
                            break;
                        case Language.English:
                            currentString = muiti.dataArray[i].English;
                            break;
                    }
                }
            }
            return currentString;
        }
        public Font UpdateTextFont(Language language, LanguageFont languageFont)
        {
            switch (languageFont)
            {
                case LanguageFont.Bold:
                    if (language == Language.TraditionalChinese)
                    {
                        _languagefont = LanguageManager.Instance.languageFont_TC_Bold;
                        if(FontSize_CH != 0) multiText.fontSize = FontSize_CH;
                    }
                    else if (language == Language.SimplifiedChinese)
                    {
                        _languagefont = LanguageManager.Instance.languageFont_SC_Bold;
                        if (FontSize_CH != 0) multiText.fontSize = FontSize_CH;
                    }
                    else if (language == Language.English)
                    {
                        _languagefont = LanguageManager.Instance.languageFont_EN_Bold;
                        if (FontSize_EN != 0) multiText.fontSize = FontSize_EN;
                    }
                    break;
                case LanguageFont.Medium:
                    if (language == Language.TraditionalChinese)
                    {
                        _languagefont = LanguageManager.Instance.languageFont_TC_Medium;
                        if (FontSize_CH != 0) multiText.fontSize = FontSize_CH;
                    }
                    else if (language == Language.SimplifiedChinese)
                    {
                        _languagefont = LanguageManager.Instance.languageFont_SC_Medium;
                        if (FontSize_CH != 0) multiText.fontSize = FontSize_CH;
                    }
                    else if (language == Language.English)
                    {
                        _languagefont = LanguageManager.Instance.languageFont_EN_Regular;
                        if (FontSize_EN != 0) multiText.fontSize = FontSize_EN;
                    }
                    break;
            }
            return _languagefont;
        }
    }
}
