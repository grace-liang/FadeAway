using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

    public Image level;
    public float fadeDuration = 2.0f;

    public void OnLevelWasLoaded()
    {
        if (!Global.levelImageSeen)
        {
            level.CrossFadeAlpha(0.0f, fadeDuration, false);
            Global.levelImageSeen = true;
        }
        else
        {
            level.CrossFadeAlpha(0.0f, 0.0f, false);
        }
    }
}
