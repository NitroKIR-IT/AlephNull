using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextImporter : MonoBehaviour {
	public Canvas textBox;
	public Canvas JoystickDisable;
	public Canvas ButtonDisable;
	public Text theText;

	public TextAsset textFile;
	public string[] textLines;
	
	public int currentLine;
	public int endAtLine;
	private InputManager input;
	public bool waitforinput;
	//tambahin public bool canMove;
	//dan juga if(!canMove){
	//	return;}
	//di void update
	
	
	// Use this for initialization
	void Start () {
		textLines = new string[]{ "initiliazie"};
		DisableTextBox ();
		input = FindObjectOfType<InputManager> ();
	}
	void Update(){
		//if ((currentLine < textLines.Length) && (InputManager.Button01())) {
			theText.text = textLines [currentLine];
			//Debug.Log ();
		//Debug.Log (InputManager.Button01());
		//masukin input manager button
		if((input.EndOfTouchFromScreen()||Input.GetKeyDown(KeyCode.Space))&&waitforinput){
			if(currentLine == endAtLine){
				DisableTextBox();
			}
			currentLine ++;
			Debug.Log (currentLine);
		}
		if (Input.GetKeyDown(KeyCode.CapsLock)){
			//ReloadScript("a.txt");
		}
		
	}
	
	public void EnableTextBox(){
		textBox.enabled = true;
		JoystickDisable.enabled = false;
		ButtonDisable.enabled = false;
	}
	
	public void DisableTextBox(){
		waitforinput = false;
		textBox.enabled = false;
		Debug.Log ("it should be gone");
		JoystickDisable.enabled = true;
		ButtonDisable.enabled = true;

	}
	
	public void ReloadScript(string targetfile){
		EnableTextBox ();
		waitforinput = true;
		textLines = LoadManager.GetArray (targetfile);
		Debug.Log (textLines);
		currentLine = 0;
		endAtLine = textLines.Length-2;
	}
}