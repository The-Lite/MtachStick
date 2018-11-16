using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
		GameObject Panel;
	[SerializeField]
		GameObject Text;
		WinObject win;
		CheckPos check;
	[SerializeField]
		int x;

	// Use this for initialization
void Start ()
	 {
		win =FindObjectOfType<WinObject>();
		check=FindObjectOfType<CheckPos>();
	 }
	
	// Update is called once per frame
void Update () 
	{

		if(win.Correct==true && check.PosndRot==true)
		 {	
			Panel.SetActive(true);
			Text.SetActive(true);
			Time.timeScale=0;		
		 }
	}
public 	void loadAPP()
	{
		if(win.Correct==true && check.PosndRot==true)
		{
			SceneManager.LoadScene(x);
		}
	}
}
