using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkOpener : MonoBehaviour
{
    public void OnClickVK()
    {
        Application.OpenURL("https://vk.com/mistymoondevelop");
    }

    public void OnClickGJ()
    {
        Application.OpenURL("https://gamejolt.com/@MistyMoonRu");
    }
    public void OnClickItch()
    {
        Application.OpenURL("https://mistymoonrussia.itch.io/");
    }
}
