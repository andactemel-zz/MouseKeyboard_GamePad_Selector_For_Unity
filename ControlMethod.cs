﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMethod : MonoBehaviour {

	public bool joystick=false;
    public UiControlChanger _UiControlChanger;

    // Use this for initialization
    void Start () {
		
	}

	public void ControlMethodScript(){
		if (joystick) {
			
			if (Input.GetAxis ("Mouse X") != 0f
				|| Input.GetAxis ("Mouse Y") != 0f
				|| Input.GetAxis("Fire1")!=0f
				|| Input.GetButton("Fire2")
				|| Input.GetButton("Fire3")
				|| Input.GetAxis ("Horizontal") != 0f
				|| Input.GetAxis ("Vertical") != 0f) {
				joystick = false;
              


            }
		} else {
			
			if ( ((Input.GetAxis ("Mouse X_Pad")  <1.1f && Input.GetAxis ("Mouse X_Pad")  >-1.1f) && (Input.GetAxis ("Mouse X_Pad")>0.1f || Input.GetAxis ("Mouse X_Pad")<-0.1f))
				|| ((Input.GetAxis ("Mouse Y_Pad")  <1.1f && Input.GetAxis ("Mouse Y_Pad")  >-1.1f) && (Input.GetAxis ("Mouse Y_Pad")>0.1f || Input.GetAxis ("Mouse Y_Pad")<-0.1f))
				|| Input.GetAxis("Fire1_Pad")!=0f
				|| Input.GetButton("Fire2_Pad")
				|| Input.GetButton("Fire3_Pad")
				|| Input.GetAxis ("Horizontal_Pad") != 0f
				|| Input.GetAxis ("Vertical_Pad") != 0f) {
				joystick = true;
               

            }


		}

	}


}
