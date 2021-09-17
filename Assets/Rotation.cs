using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Transform.rotation example.

// Rotate a GameObject using a Quaternion.
// Tilt the cube using the arrow keys. When the arrow keys are released
// the cube will be rotated back to the center using Slerp.

public class Rotation : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    public GameObject rotationTextObject;
    public string[] PhraseList = new string[3] { "good", "bad", "meh" };

    System.Random rand = new System.Random();
    void Update()
    { 
        if (transform.hasChanged)
        {
            print("The transform has changed!");
            transform.hasChanged = false;
            int index = rand.Next(PhraseList.Length);
            rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
        }

        // Smoothly tilts a transform towards a target rotation.
        // float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        // float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // // Rotate the cube by converting the angles into a quaternion.
        // Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // // Dampen towards the target rotation
        // transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

        // if (){
        //     int index = rand.Next(PhraseList.Length);
        //     rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
        // }
    }
}
