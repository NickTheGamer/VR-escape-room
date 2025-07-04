using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyLock : MonoBehaviour
{
    //variables
    private IXRSelectInteractable item;
    public GameObject drawer;
    public GameObject key_vr;
    public BoxCollider text_collider;
    public GameObject padlock;
    public void itemAdded()
    {
        item = GetComponent<XRSocketInteractor>().GetOldestInteractableSelected();
        drawer.GetComponent<ConfigurableJoint>().zMotion = ConfigurableJointMotion.Limited;
        key_vr.SetActive(false);
        text_collider.enabled = true;
        padlock.SetActive(false);
    }

    public void itemRemoved()
    {
        item = null;
    }
}
