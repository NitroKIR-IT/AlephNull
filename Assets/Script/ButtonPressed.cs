using UnityEngine;
using System.Collections;

public class ButtonPressed : MonoBehaviour {

	public bool buttonx;

	// Use this for initialization
	void Start () {
	
		buttonx = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnPress(bool pressed)
	{
		if (pressed)
		{
			Debug.Log("Now is pressed");
			buttonx = true;
		}                      
		else
		{
			buttonx = false;
			Debug.Log("Now is released");
		}                      
	}
}


