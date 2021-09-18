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
    private float movementSpeed = 5f;

    public GameObject rotationTextObject;
    public string[] PhraseList = new string[4] { "good", "bad", "meh", "other words" };

    System.Random rand = new System.Random();

    float rotationSpeed = 45;
    Vector3 currentEulerAngles;
    float x;
    float y;
    float z;
    Vector3 oldEulerAngles;
    public Transform target;
    int index;
    void Start(){
        oldEulerAngles = transform.rotation.eulerAngles;
    }

    void Update()
    { 
        if ((transform.rotation.eulerAngles.x <= (oldEulerAngles.x + 0.1f) && transform.rotation.eulerAngles.x >= (oldEulerAngles.x - 0.1f)) ||
            (transform.rotation.eulerAngles.y <= (oldEulerAngles.x + 0.1f) && transform.rotation.eulerAngles.y >= (oldEulerAngles.x - 0.1f)) ||
            (transform.rotation.eulerAngles.z <= (oldEulerAngles.x + 0.1f) && transform.rotation.eulerAngles.z >= (oldEulerAngles.x - 0.1f)) ){
        
        // Vector3 targetDir = target.position - transform.position;
        // float angle = Vector3.Angle(targetDir, transform.forward);
        // if (angle < 5.0f){
           //NO ROTATION
            index = rand.Next(PhraseList.Length);
            rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
            // rotationTextObject.GetComponent<TextMeshPro>().text = "No change";
        } else{
            oldEulerAngles = transform.rotation.eulerAngles;
            // rotationTextObject.GetComponent<TextMeshPro>().text = transform.rotation.ToString();
            int index2 = rand.Next(PhraseList.Length);
            if (index2 != index){
                rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
            }
            //DO WHATEVER YOU WANT
        }
        // if (transform.hasChanged)
        // {
        //     print("The transform has changed!");
        //     transform.hasChanged = false;
        //     int index = rand.Next(PhraseList.Length);
        //     rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
        // }

        // Smoothly tilts a transform towards a target rotation.
        // float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        // float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // // Rotate the cube by converting the angles into a quaternion.
        // Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // // Dampen towards the target rotation
        // transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

        // rotationTextObject.GetComponent<TextMeshPro>().text = transform.rotation.ToString();
        // // if (){
        //     // int index = rand.Next(PhraseList.Length);
        //     // rotationTextObject.GetComponent<TextMeshPro>().text = PhraseList[index];
        // // }

        // //get the Input from Horizontal axis
        // float horizontalInput = Input.GetAxis("Horizontal");
        // //get the Input from Vertical axis
        // float verticalInput = Input.GetAxis("Vertical");

        // //update the position
        // transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

        // // rotationTextObject.GetComponent<TextMeshPro>().text = transform.position.ToString();
        // //output to log the position change
        // Debug.Log(transform.position);
    }
}

