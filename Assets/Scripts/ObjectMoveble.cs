using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveble : MonoBehaviour {
  		bool Selected ;
  [SerializeField]
 		 GameObject Obj;
  [SerializeField]
  
  		SpriteRenderer rend;
		WinObject win;
		CheckPos check;
  		ButtonRotation button;
	// Use this for initialization
void Start ()
 {
		win=FindObjectOfType<WinObject>();
		check=FindObjectOfType<CheckPos>();
		button=FindObjectOfType<ButtonRotation>();
}
	
	// Update is called once per frame
void Update ()
 {

	//	if(win.Correct==false && check.PosndRot==false ||win.Correct==true && check.PosndRot==false || win.Correct==false && check.PosndRot==true )/*Cheak if all conditions to pause the game whene the player win */
		//{

		
			if(Selected==true)
			{
			Vector2 curspos=Camera.main.ScreenToWorldPoint(Input.mousePosition);// taking the mouse position
			transform.position=new Vector2(curspos.x,curspos.y);//folowing the mouse position
				
			Obj.SetActive(true);//child of obj
			rend.color=Color.blue;//render the child

			}
		
			if(Input.GetMouseButtonUp(0))
				{
				Selected=false;
				Obj.SetActive(false);
				rend.color=Color.red;
				
				}
		//}
	}

void OnMouseOver()
{
	if(Input.GetMouseButtonDown(0))
	{
		Selected=true;
	}
}

}
