using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class volsetting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider musicsl;

    public void setmusicvol()
    {
        float volume = musicsl.value;
        audioMixer.SetFloat("master",Mathf.Log10(volume)*20);
    }
}
