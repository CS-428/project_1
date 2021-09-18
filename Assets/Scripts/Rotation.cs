using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Rotation : MonoBehaviour
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
    public string[] PhraseList = new string[20] { 
        // Good outcomes
        "It is Certain",
        "It is decidedly so",
        "Without a doubt",
        "Yes definitely",
        "You may rely on it",
        "As I see it, yes",
        "Most likely",
        "Outlook good",
        "Yes",
        "Signs point to yes",

        // Unclear outcomes
        "Reply hazy, try again",
        "Ask again later",
        "Better not tell you now",
        "Cannot predict now",
        "Concentrate and ask again",

        // Negative outcomes
        "Don't count on it",
        "My reply is no",
        "My sources say no",
        "Outlook not so good",
        "Very doubtful"
    };
    void Start(){
        oldEulerAngles = transform.rotation.eulerAngles;
    }

    void Update()
    { 
            if (/*(Math.Abs(transform.rotation.eulerAngles.x - oldEulerAngles.x) > 90f ) ||*/
                // (Math.Abs(transform.rotation.eulerAngles.y - oldEulerAngles.y) > 90f ) ||
                (Math.Abs(transform.rotation.eulerAngles.z - oldEulerAngles.z) > 90f ) ){
        
            oldEulerAngles = transform.rotation.eulerAngles;
            index = rand.Next(PhraseList.Length);
            rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
        } else{
            rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
        }
    }
}

