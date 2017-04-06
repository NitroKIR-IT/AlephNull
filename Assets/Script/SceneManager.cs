using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
	// Belom selesai
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Change_Scene (string sName)
	{
		Application.LoadLevel (sName);
		Debug.Log ("sss");
	}
}
