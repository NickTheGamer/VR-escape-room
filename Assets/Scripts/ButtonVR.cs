using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public float deadTime = 1.0f;
    private bool _deadTimeActive = false;
    public GameObject parent;

    public UnityEvent onPressed, onReleased;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Button" && !_deadTimeActive) {
            onPressed?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Button" && !_deadTimeActive) {
            onReleased?.Invoke();
            StartCoroutine(WaitForDeadTime());
        }
    }

    IEnumerator WaitForDeadTime() {
        _deadTimeActive = true;
        parent.GetComponent<WinScript>().ButtonOn();
        yield return new WaitForSeconds(deadTime);
        _deadTimeActive = false;
        parent.GetComponent<WinScript>().ButtonOff();
    }

}
