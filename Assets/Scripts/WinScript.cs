using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    private bool buttonPressed = false;
    private bool textInPlace = false;
    public GameObject winText;

    public void Update()
    {
        if (buttonPressed && textInPlace)
        {
            winText.SetActive(true);
            StartCoroutine(End());
        }
    }
 
    IEnumerator End()
    {
        yield return new WaitForSeconds(6);
        Application.Quit();
    }

    public void ButtonOn()
    {
        buttonPressed = true;
    }

    public void ButtonOff()
    {
        buttonPressed = false;
    }

    public void Text()
    {
        textInPlace = true;
    }
}
