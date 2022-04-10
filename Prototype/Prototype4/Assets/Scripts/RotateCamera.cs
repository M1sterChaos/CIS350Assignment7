/*
 * (Austin Buck)
 * (Assignment 7)
 * (Controls the camera movement)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rSpeed;

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, hInput * rSpeed * Time.deltaTime);
    }
}
