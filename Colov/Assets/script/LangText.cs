using TMPro;
using UnityEngine;

public class LangText : MonoBehaviour
{
    public string fr, en;
    TextMeshProUGUI tmpro => GetComponent<TextMeshProUGUI>();

void Start()
{
    ChangeLanguage();
}


    public void ChangeLanguage()
    {
        switch(LanguageManager.currentLangue)
        {
            case LanguageManager.Language.fr: tmpro.text = fr; break;
            case LanguageManager.Language.en: tmpro.text = en; break;
        }
    }
}
