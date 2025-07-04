using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLock : MonoBehaviour
{
    //variables
    public GameObject InactiveText;
    public GameObject parent;

    public void ItemAdded()
    {
        InactiveText.SetActive(false);
        parent.GetComponent<WinScript>().Text();
    }

}
