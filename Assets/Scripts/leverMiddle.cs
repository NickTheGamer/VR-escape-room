using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverMiddle : MonoBehaviour
{
    public HingeJoint joint;
    public GameObject parent;

    // Update is called once per frame
    void Update()
    {
        if (joint.angle <= -60)
        {
            parent.GetComponent<LeverParent>().middleLeverCorrect();
        }

        if (joint.angle > -60) {
            parent.GetComponent<LeverParent>().middleLeverWrong();
        }
    }
}
