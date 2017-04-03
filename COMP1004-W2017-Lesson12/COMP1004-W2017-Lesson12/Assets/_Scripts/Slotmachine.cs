using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slotmachine : MonoBehaviour {

    float currentRotation = 0;
	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {

        currentRotation = transform.rotation.z;
        currentRotation += 0.5f;

        Debug.Log("Current Rotation: " + currentRotation);

        transform.Rotate(0, 0, currentRotation);

	}
}
