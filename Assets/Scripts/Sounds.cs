using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    private int waitTime = 80;
    public AudioSource source;
    public AudioClip sonar;
    public AudioClip whale1;
    public AudioClip whale2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        source.PlayOneShot(sonar);
        yield return new WaitForSeconds(10);
        source.PlayOneShot(whale1);
        yield return new WaitForSeconds(45);
        source.PlayOneShot(whale2);
    }

}
