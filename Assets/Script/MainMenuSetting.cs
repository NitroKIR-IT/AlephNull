using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuSetting : MonoBehaviour 
{
	public Canvas MainCanvas;
	public Canvas OptionCanvas;
	public Canvas JoyStickCanvas;
	public Canvas LoadGameCanvas;
	bool LoadGameFile;//jika iya maka akan load tidak akan new game
	public Text TitleStatus; 
	private LoadManager loading;
	public static string a;
	LoadManager Load;

//	void Update(){
//		Debug.Log (LoadGameFile);
//	}
	void Awake()
	{
		Load = GetComponent<LoadManager> ();
		Load.LoadInfoFile ();
		OptionCanvas.enabled = false;
		if (LoadGameCanvas != null) {
			Debug.Log ("ssss");
			LoadGameCanvas.enabled = false;
		}
	}

	public void OptionsOn() // ketika dirun maka canvas joystick&MainCanvasmati
							//dan option nyala
	{
		if (JoyStickCanvas == null) // jika gk ad if maka kode dibawah gk bakal jalan
									// malahan ngereturn error exception
		{
			Debug.Log ("no joystick canvas");
		} else 
		{
			JoyStickCanvas.enabled = false;
		}
		OptionCanvas.enabled = true;
		LoadGameCanvas.enabled = false;
		MainCanvas.enabled = false;

	}
	public void ReturnOn () // kebalikan dari yang diatas
	{
		if (JoyStickCanvas == null) {
			Debug.Log ("no joystick canvas");
		}else 
		{
			JoyStickCanvas.enabled = true;
		}
		OptionCanvas.enabled = false;
		MainCanvas.enabled = true;

	}
	public void NewGame (){
		LoadGameFile = false;
		LoadGameCanvas.enabled = true;
		TitleStatus.text = "NEW GAME";
		a = TitleStatus.text;
	}
	public void LoadGame (){
		LoadGameFile = true;
		LoadGameCanvas.enabled = true;
		TitleStatus.text = "LOAD GAME";
		a = TitleStatus.text;
	}

	public void ChangeScene ()// bakal manggil SceneManager Script
										// masukin input dari gameobject buttonnya new game
	{
		//string name = "UserID" + saveName.ToString();
		if (a == "NEW GAME") {
			var New = GetComponent<SaveManager>();
			Debug.Log ("bibiya");
		//	New.NewGameSave ();

		} else if (a == "LOAD GAME"){
			Debug.Log ("bibiye");
			Load.LoadGameSave ();
		}
			

	}
		

	public static string GIve(){
		return a; 
	}

}
