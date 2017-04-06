using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;
[XmlRoot("UserSaveData")]




public class UserSaveData
{
	[XmlArray("SaveData"), XmlArrayItem("UserID")]
	public SaveData[] SaveData;

	[XmlAttribute("SaveID")]	
	public string idname;

	public float positionx { get; set; }
	public float positiony { get; set; }
	public float positionz { get; set; }



	public void Save(string path){
		using(var stream = new FileStream(path, FileMode.Create)){
			var serializer = new XmlSerializer(typeof(SaveData));
			serializer.Serialize(stream, this);
		}
	}

	public static UserSaveData Load(string path)
	{
		var serializer = new XmlSerializer(typeof(UserSaveData));
		using(var stream = new FileStream(path, FileMode.Open))
		{
			return serializer.Deserialize(stream) as UserSaveData;
		}
	}

	//Loads the xml directly from the given string. Useful in combination with www.text.
	public static UserSaveData LoadFromText(string text) 
	{
		var serializer = new XmlSerializer(typeof(UserSaveData));
		return serializer.Deserialize(new StringReader(text)) as UserSaveData;
	}
}
public class SaveData{
	[XmlElement("UserID")]
	public float number { get; set;}
	[XmlElement("Name")]
	public string name { get; set;}
}
[XmlRoot("SaveData")]
public class UsersList{
	public UsersList() {
		Items = new List<SaveData>();
	}
	[XmlElement("User")]
	public List<SaveData> Items { get; set;}

}