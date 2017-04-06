using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ActivateText : MonoBehaviour {
	public TextImporter theTextBox;
	public Canvas textbox;
	public bool Activated;
	public string textfilename;
	private PlayerController pl;
	// Use this for initialization
	void Start () {
		theTextBox = FindObjectOfType<TextImporter>();
		pl = FindObjectOfType<PlayerController> ();
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider other){
		
		if(other.name == "PlayerClass"){
			Debug.Log ("is it in");
			Debug.Log (Activated);
			if (Activated) {
				Activated = false;
				//Inputm.press ();
				theTextBox.ReloadScript (textfilename);
				Debug.Log ("reload succes");
			}
		}
		pl.setactive ();
	}
	void OnTriggerExit(Collider other){
		if(other.name == "PlayerClass"){
			theTextBox.DisableTextBox ();
			Debug.Log ("outbitches");
		}
		pl.setinactive();
	}
	public void OnClickButton0(){
		Activated = true;
	}










































	//public TextAsset theText;
//	
//	private int startLine;
//	private int endLine;
	
//	public TextImporter theTextBox;
//	//public InputManager Inputmanaging;
//	public bool destroywhenActivated;
//	public string textname; 
//	private bool requireButtonPress;
//	private bool waitforPress;
//	// Use this for initialization
//	void Start () {
//		requireButtonPress = false;
//		theTextBox = FindObjectOfType<TextImporter>();
//		destroywhenActivated = false;
//		waitforPress = false;
//		//Inputmanaging = FindObjectOfType<InputManager> ();
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		requireButtonPress = InputManager.Button01();
//		if(waitforPress && (InputManager.Button01()||Input.anyKeyDown)){
//			
////			theTextBox.currentLine = startLine;
////			theTextBox.endAtLine = endLine;
//			theTextBox.EnableTextBox();
//			if(destroywhenActivated){
//				Destroy(gameObject);
//			}
//		}
//	}
//	void OnTriggerStay(Collider other){
//		Debug.Log ("is it in");
//		if(other.name == "PlayerClass" && waitforPress == false){
//			if(requireButtonPress){
//				theTextBox.ReloadScript(textname);
//				waitforPress = true;
//				return;
//			}
////			theTextBox.ReloadScript(theText);
////			theTextBox.currentLine = startLine;
////			theTextBox.endAtLine = endLine;
////			theTextBox.EnableTextBox();
////			if(destroywhenActivated){
////				Destroy(gameObject);
////			}
//		}
//	}
//	void OnTriggerExit2D(Collider2D other){
//		if(other.name == "Player"){
//			destroywhenActivated = true;
//			waitforPress = false;
//		}
//	}
}