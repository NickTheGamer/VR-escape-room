using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever_child_down : MonoBehaviour
{
    public HingeJoint joint;
    public GameObject parent;

    // Update is called once per frame
    void Update()
    {
        if (joint.angle >= 60)
        {
            parent.GetComponent<LeverParent>().rightLeverCorrect();
        }

        if (joint.angle < 60) {
            parent.GetComponent<LeverParent>().rightLeverWrong();
        }
    }
}
