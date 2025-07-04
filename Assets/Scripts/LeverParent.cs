using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverParent : MonoBehaviour
{
    public GameObject glass;
    private bool leftLever;
    private bool middleLever;
    private bool rightLever;
    public BoxCollider key;
    void Update() {
        if (leftLever && middleLever && rightLever) {
            glass.SetActive(false);
            key.enabled = true;
        }
    }

    public void leftLeverCorrect() {
        leftLever = true;
    }

    public void leftLeverWrong() {
        leftLever = false;
    }

    public void middleLeverCorrect() {
        middleLever = true;
    }

    public void middleLeverWrong() {
        middleLever = false;
    }

    public void rightLeverCorrect() {
        rightLever = true;
    }

    public void rightLeverWrong() {
        rightLever = false;
    }

}
