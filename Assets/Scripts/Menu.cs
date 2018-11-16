using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	[SerializeField]
	GameObject Panel;
   static bool GamePause=false;


	
	// Update is called once per frame
void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(GamePause)
			{
				Resume();
			}
			else
			 {
				 Pause();
			 }
		}
	}

void Resume()
		{
			Panel.SetActive(false);	
			GamePause=false;
		}
void Pause()
	{
		Panel.SetActive(true);
		GamePause=true;
	}

}
