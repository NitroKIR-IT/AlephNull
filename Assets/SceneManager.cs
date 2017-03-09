using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
    string SceneName;
    GameObject sceneinfo;
    
	// Use this for initialization
	void Start () {
        sceneinfo = GameObject.Find("SceneInfo");
        InfoScene Instant = sceneinfo.GetComponent<InfoScene>();
        SceneName = Instant.GetInfo();
        Debug.Log(SceneName);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown) {
            Debug.Log(SceneName);
            Load_Level(SceneName);
        }	
	}

    void Load_Level(string name) {
        Application.LoadLevel(SceneName);

    }


}
