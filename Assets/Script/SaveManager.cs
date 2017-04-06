using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;

public class SaveManager : MonoBehaviour {



	public string TextName;
	public string paths;
	XmlDocument docx = new XmlDocument ();



	// Use this for initialization
	void Start () {
		paths = Application.persistentDataPath + "/SaveData/SaveFiles.xml";
		var directory = Path.GetDirectoryName (paths);
		if (!Directory.Exists (directory)) {
			Directory.CreateDirectory(directory);
		}
		SaveData ("UsersID[2]/Name", "taaianbego");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SaveData (string whatdatas, string setto){
		if (!File.Exists (paths)) {
			initialize (paths);
		}
		docx.Load (paths);
		XmlNode nodes = docx.DocumentElement.SelectSingleNode(whatdatas);
		nodes.InnerText = setto;
		docx.Save (paths);
	}

	public string LoadData (string thisdatas){
		if (!File.Exists (paths)) {
			Debug.Log ("error no path found");
			return null;
		} else {
			docx.Load (paths);
		}
		XmlNode nodes = docx.DocumentElement.SelectSingleNode(thisdatas);
		string getto = nodes.InnerText;
		return getto;
	}
	// When Derived Please Put XMLInclude

	public void initialize (string pathe){
		XmlWriter writter = XmlWriter.Create (pathe);
		writter.WriteStartElement ("SaveDatas");//1
		writter.WriteStartElement ("UsersID");//2
		writter.WriteStartAttribute ("ID");//3
		writter.WriteValue (1);
		writter.WriteEndAttribute ();//3
		writter.WriteStartElement ("Name");//4
		writter.WriteEndElement (); 	//4
		writter.WriteStartElement ("LastPlay");//5
		writter.WriteEndElement ();
		writter.WriteStartElement ("Progress");//5
		writter.WriteEndElement ();
		writter.WriteStartElement ("LPosX");//5
		writter.WriteEndElement (); //5
		writter.WriteStartElement ("LPosY");//5
		writter.WriteEndElement (); //5
		writter.WriteStartElement ("LPosZ");//5
		writter.WriteEndElement (); //5
		writter.WriteEndElement ();//2

		writter.WriteStartElement ("UsersID");
		writter.WriteStartAttribute ("ID");
		writter.WriteValue (2);
		writter.WriteEndAttribute ();
		writter.WriteStartElement ("Name");//4
		writter.WriteEndElement (); 	//4
		writter.WriteStartElement ("LastPlay");//5
		writter.WriteEndElement ();
		writter.WriteStartElement ("Progress");//5
		writter.WriteEndElement ();
		writter.WriteStartElement ("LPosX");//5
		writter.WriteEndElement (); //5
		writter.WriteStartElement ("LPosY");//5
		writter.WriteEndElement (); //5
		writter.WriteStartElement ("LPosZ");//5
		writter.WriteEndElement (); //5d
		writter.WriteEndElement ();//1

		writter.WriteStartElement ("UsersID");
		writter.WriteStartAttribute ("ID");
		writter.WriteValue (3);
		writter.WriteEndAttribute ();
		writter.WriteStartElement ("Name");//4
		writter.WriteEndElement (); 	//4
		writter.WriteStartElement ("LastPlay");//5
		writter.WriteEndElement ();
		writter.WriteStartElement ("Progress");//5
		writter.WriteEndElement ();
		writter.WriteStartElement ("LPosX");//5
		writter.WriteEndElement (); //5
		writter.WriteStartElement ("LPosY");//5
		writter.WriteEndElement (); //5
		writter.WriteStartElement ("LPosZ");//5
		writter.WriteEndElement (); //5d
		writter.WriteEndElement ();//1

		writter.Close ();
	}

	public void NewGameSave (){
		var scene = GetComponent<SceneManager> ();
		scene.Change_Scene ("PlayGround");
	}
}
	
