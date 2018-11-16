using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotation : MonoBehaviour {
  		 [SerializeField]
   			public   Transform obj;// stacking the selectble object
			Vector2 curspos;
	 		RaycastHit2D hit;
	 		bool Selected;
	 		SpriteRenderer sprite;
		 [SerializeField]
			 float valeu;// the range of raycas
	 		int x;
		 	int y=1;// slect the child to turn on the highlight
			 Transform switchToNext;// the next obj selected
			 SpriteRenderer spriteNext;// the child obj which gonna be highlighted
			WinObject win;
			CheckPos check;

	// Use this for initialization
void Start () {

		  win=FindObjectOfType<WinObject>();
		  check=FindObjectOfType<CheckPos>();	
        }
	 
	// Update is called once per frame
void Update () {
					
		if(win.Correct==false && check.PosndRot==false ||win.Correct==true && check.PosndRot==false || win.Correct==false && check.PosndRot==true ) /*Cheak if all conditions to pause the game whene the player win */
	/	{
		  if(Input.GetMouseButton(1))
			{
		      curspos =Camera.main.ScreenToWorldPoint(Input.mousePosition);//geting info from the mouse in the game 
		     hit=Physics2D.Raycast(curspos,curspos,valeu); // getting what the mouse hit 
		      Debug.DrawRay(curspos,curspos);
		      if(hit.collider.tag=="slic")
				 {
					/*Slic  is a tag used to reffere the object which the player should slecte */
				 obj=hit.transform.GetComponent<Transform>();//stacking the hit data to an obj 
				 sprite=obj.GetChild(y).GetComponent<SpriteRenderer>();// stacking the render of the hting obj
			     sprite.enabled=true;	// trun on the render to hilight the obj
				 x=(int)obj.eulerAngles.z; // taking the angle of the selected object 
				 }
	
			}
			/* turning of the highlight obj if we select other object and turn on the new object  */
		  if(switchToNext==null)
			 {
				// See The documentation
				 switchToNext=obj;
				 spriteNext=sprite;
				 if(switchToNext!=obj)	
			     {
				 spriteNext.enabled=false;
			     }
			
			    if(switchToNext!=null)
			     {
					if(switchToNext!=obj)	
			        {
				     spriteNext.enabled=false;
				     switchToNext=obj;
				     spriteNext=sprite;

			         }
					

			     }
			
		    }
		 	}
	
	}
/* Rotate the object */
public void ButtonClick()
{
	//See the Documentation

	switch(x)
	{
		case 90 :
		{
			Vector3 d1 = new Vector3 (0,0,45);
				 obj.Rotate(new Vector3 (0,0,45));
			break;
		}
		case 45 : 
		{
			Vector3 d1 = new Vector3 (0,0,180);
				 obj.Rotate(d1);
			break;
		}
		case 180 :
		{
			Vector3 d1 = new Vector3 (0,0,-45);
				 obj.Rotate(d1);

			break;
		}
		case -45 :
		{
			Vector3 d1 = new Vector3 (0,0,90);
				 obj.Rotate(d1);

			break;
		}
		case 135 :
		{
				Vector3 d1 = new Vector3 (0,0,90);
				 obj.Rotate(d1);

			break;
		}
case 0 :
		{
				Vector3 d1 = new Vector3 (0,0,180);
				 obj.Rotate(d1);

			break;
		}
	}
}
	
void MouseChocie()
{
	if(Input.GetMouseButtonDown(1))
	{
		Selected=true;
	}
}

}
