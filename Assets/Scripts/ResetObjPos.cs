using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObjPos : MonoBehaviour {
	
	[SerializeField]
	Transform [] primaryObj;//first obj of the selectble obj
	[SerializeField]
	Vector3[] primaryPos;//first position of the selectble obj
	ButtonRotation button;
	// Use this for initialization
void Start () {
		/*stocking the data of positions */
		button=FindObjectOfType<ButtonRotation>();
		for(int i=0;i< primaryObj.Length;i++)
		{
			primaryPos[i]=primaryObj[i].position;
		}
	}
	
	//Return the obj to the primary position ( Button )
public void Back()
	{
			for(int i=0;i<primaryObj.Length;i++)
			{
				if(button.obj==primaryObj[i])
				{
				button.obj.position=primaryPos[i];
				}
			}
	}


}
