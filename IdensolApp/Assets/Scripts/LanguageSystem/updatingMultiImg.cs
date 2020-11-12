using UnityEngine;
using UnityEngine.UI;

namespace MinYan.Lang
{
    [RequireComponent(typeof(Image))]
    public class updatingMultiImg: MonoBehaviour
    {
        public Sprite TCImage;
        public Sprite SCImage;
        public Sprite ENImage;
        public Image thisImage;

        public void Set()
        {
            thisImage.sprite = ChangeSprite(LanguageManager.Instance.language);
        }
        public Sprite ChangeSprite(Language language)
        {
            if (thisImage)
            {
                switch (language)
                {
                    case Language.TraditionalChinese:
                        thisImage.sprite = TCImage;
                        break;
                    case Language.SimplifiedChinese:
                        thisImage.sprite = SCImage;
                        break;
                    case Language.English:
                        thisImage.sprite = ENImage;
                        break;
                }
            }
            return thisImage.sprite;
        }
    }
}

