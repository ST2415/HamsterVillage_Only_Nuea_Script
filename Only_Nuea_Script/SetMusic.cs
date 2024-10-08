using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetMusic : MonoBehaviour
{
    // Slider volumeSetting;
    [SerializeField] AudioMixer mixer;
    
    

    public void SetVolume(float value)
    {
        //mixer.SetFloat("volume", volumeSetting.value);
        mixer.SetFloat("volume", Mathf.Log10(value) * 20);
        mixer.SetFloat("MainVolume", Mathf.Log10(value) * 20);
        mixer.SetFloat("SFXvolume", Mathf.Log10(value) * 20);
    }
    // Start is called before the first frame update
    void Start()
    {
        //mixer.GetFloat("volume", out value);
        //volumeSetting.value = value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
