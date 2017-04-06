using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuSetting : MonoBehaviour 
{
	public Canvas MainCanvas;
	public Canvas OptionCanvas;

	void Awake()
	{
		OptionCanvas.enabled = false;
	}

	public void OptionsOn()
	{
		OptionCanvas.enabled = true;
		MainCanvas.enabled = false;
	}
	public void ReturnOn ()
	{
		OptionCanvas.enabled = false;
		MainCanvas.enabled = true;
	}
	public void ChangeScene (string sceneName)
	{
		Application.LoadLevel (sceneName);
	}

}
