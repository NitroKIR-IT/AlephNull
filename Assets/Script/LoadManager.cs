using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;

public class LoadManager : MonoBehaviour {
	public static string FileName;
	public string txtName;
	private string Currentline;
	public static TextAsset ReadingFile;
	public static string[] lines;



	// Use this for initialization
	void Start () {
		GetArray ("a");//testing not important



	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log (MainMenuSetting.GIve()); for testing puposes
	}

	public static string[] GetArray(string nameoftext){
		FileName = "TextFile/" + nameoftext;//ini cuman buat text di resource/textfile
		ReadingFile = (TextAsset)Resources.Load (FileName);
		if (ReadingFile != null) {
			lines = (ReadingFile.text.Split ('\n'));
		}
		//for testing purposes
//		foreach (var item in lines) {
//			Debug.Log (item.ToString());
//		}
//
		//string[] returnstr = new string[lines.Count+1];
		return lines;

	}

	public void LoadGameSave (){




		var scene = GetComponent<SceneManager> ();
		scene.Change_Scene ("PlayGround");
	}
	public void LoadInfoFile (){
		var a = GetComponent<SaveManager> ();
		Debug.Log(a.LoadData ("Name"));
	}
}
