using UnityEngine;
using UnityEngine.UI;

namespace MinYan.Lang
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class updatingMultiSprite : MonoBehaviour
    {
        public Sprite TCSprite;
        public Sprite SCSprite;
        public Sprite ENSprite;
        public SpriteRenderer thisSprite;

        public void Set()
        {
            thisSprite.sprite = ChangeSprite(LanguageManager.Instance.language);
        }
        public Sprite ChangeSprite(Language language)
        {
            if (thisSprite)
            {
                switch (language)
                {
                    case Language.TraditionalChinese:
                        thisSprite.sprite = TCSprite;
                        break;
                    case Language.SimplifiedChinese:
                        thisSprite.sprite = SCSprite;
                        break;
                    case Language.English:
                        thisSprite.sprite = ENSprite;
                        break;
                }
            }
            return thisSprite.sprite;
        }
    }
}
