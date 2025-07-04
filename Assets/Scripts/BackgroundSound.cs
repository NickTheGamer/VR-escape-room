using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    public AudioSource source;
    private int waitTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());   
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        source.Play();
    }

}
