using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class InputManager : MonoBehaviour {
	public bool pressed;
	public float AxisX;
	public float AxisY;
	public static bool button1;
	public VJoyStick JOYSTICK;

	// Use this for initialization
	void Start () {
		
	}
	// Axis Code
	// Update is called once per frame
	void Update () {
		//Debug.Log(EndOfTouchFromScreen ());


	}
	public float GetAxisX(){
//		Debug.Log ("tasdes");
		return JOYSTICK.Vertical ();

	}

	public float GetAxisY(){
		//var JoyStickInst = new VJoyStick ();
		return JOYSTICK.Horizontal ();
	
	}

	public bool EndOfTouchFromScreen(){
		bool touch = false;
		if (Input.touchCount > 0) {
			if (Input.GetTouch (0).phase == TouchPhase.Ended) {
				touch = true;
			}
		}
		return touch;
	}
		
	//Button Press Code
//	public static bool Button01 (){
//
//
//		return button1;         fail
//	}
//
//
//
//
//	public void press (){
//		button1 = !button1;
//		if (button1) {
//		
//		}
//	}
	public void New_Game (float slot){
		


	}


}
