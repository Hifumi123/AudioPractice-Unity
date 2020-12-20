using UnityEngine;

public class PlaySpaceEffectSound : MonoBehaviour
{
    public string eventName = null;

    void Start()
    {
        if (!string.IsNullOrEmpty(eventName))
            AkSoundEngine.PostEvent(eventName, gameObject);
    }

    void Update()
    {
        
    }
}
