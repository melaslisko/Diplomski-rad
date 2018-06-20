using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    private Toggle soundtoggle;

    // Use this for initialization
    void Start()
    {
        soundtoggle = GameObject.FindGameObjectWithTag("SoundToggle").GetComponent<Toggle>();
    }

    public void Mute()
    {
        if (soundtoggle.isOn)
        {
            AudioListener.volume = 0;
        }
        else if (!soundtoggle.isOn) AudioListener.volume = 1;
    }
}