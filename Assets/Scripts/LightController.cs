using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject roofLight;
    public AudioSource source;
    public AudioClip lightSwitch;
    //public AudioClip Creaking;

    public void Grabbed()
    {
        source.PlayOneShot(lightSwitch);
        roofLight.SetActive(false);
    }

}
