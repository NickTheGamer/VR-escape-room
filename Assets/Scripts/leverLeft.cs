using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class leverChild : MonoBehaviour
{
    public HingeJoint joint;
    public GameObject parent;

    // Update is called once per frame
    void Update()
    {
        if (joint.angle <= -60){
            parent.GetComponent<LeverParent>().leftLeverCorrect();
        }
        if (joint.angle > -60) {
            parent.GetComponent<LeverParent>().leftLeverWrong();
        }
    }
}
