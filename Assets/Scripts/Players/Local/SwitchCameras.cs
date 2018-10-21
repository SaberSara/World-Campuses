using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour {

    //Attributes
    [SerializeField] Camera charCam;
    [SerializeField] Transform FPSTrans;
    [SerializeField] Transform TPSTrans;
    [SerializeField] GameObject smoothFollow;

    //Functions

	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Change Camera while pressing mouse Button 1/2 to FPS/TPS while playing!
        if (Input.GetMouseButtonDown(1))
        {
            charCam.transform.position = FPSTrans.transform.position;
            charCam.transform.rotation = FPSTrans.transform.rotation;
            smoothFollow.SetActive(false);
        }
        //Change Camera while pressing mouse Button 1/2 to FPS/TPS while playing!
        if (Input.GetMouseButtonDown(2))
        {
            charCam.transform.position = TPSTrans.transform.position;
            charCam.transform.rotation = TPSTrans.transform.rotation;
            smoothFollow.SetActive(true);
        }

    }
}
