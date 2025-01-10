using UnityEngine;

public class LanguageManager : MonoBehaviour
{

    public enum Language{fr, en}
    public static Language currentLangue= Language.fr;

 

    public static void ChangeLanguage(Language Desired)
    {
        currentLangue = Desired;
        foreach (LangText texteachanger in FindObjectsByType<LangText>(FindObjectsSortMode.None))
        {
           texteachanger.ChangeLanguage();

        }
    }

    public void ButtonChangeFR()
    {
        ChangeLanguage(Language.fr);
    }

    public void ButtonChangeEN()
    {
        ChangeLanguage(Language.en);
    }

}
