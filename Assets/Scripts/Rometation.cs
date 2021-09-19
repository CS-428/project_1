using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Rometation : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngle = 60.0f;
    private float movementSpeed = 5f;

    public GameObject rotationTextObject;
    System.Random rand = new System.Random();
    Vector3 currentEulerAngles;
    Vector3 oldEulerAngles;
    float x, y, z;
    public Transform target;
    int index;
    public string[] PhraseList = new string[] { 
        // Good outcomes
        "Yes",
        "Lookin' Good!",
        "You'll be happy today",
        "Poggers",

        // Unclear outcomes
        "I dunno...",
        "Out for lunch. Return later",
        "Please reconnect to the internet",

        // Negative outcomes
        "Mercury is in retrograde",
        "Not lookin' too hot",
        "Big yikes",
        "This ain't it, chief"
    };
    void Start()
    {
        oldEulerAngles = transform.rotation.eulerAngles;
    }

    void Update()
    { 
            if (//(Math.Abs(transform.rotation.eulerAngles.x - oldEulerAngles.x) > 90f ) ||
                // (Math.Abs(transform.rotation.eulerAngles.y - oldEulerAngles.y) > 90f ) //||
                (Math.Abs(transform.rotation.eulerAngles.z - oldEulerAngles.z) > 90f ) ){
        
            oldEulerAngles = transform.rotation.eulerAngles;
            index = rand.Next(PhraseList.Length);
            rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
        } else{
            rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
        }
    }
}

