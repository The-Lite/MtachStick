using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPos : MonoBehaviour {
	public	bool PosndRot=false;
	[SerializeField]
	Vector3[] pos;//stokcing primary position 
	[SerializeField]
	Transform[] trans; // the object which its position change
	[SerializeField]
	Vector3[] rotation; // stocking the primary rotation
	// Use this for initialization
void Start () 
	{
		for(int i=0;i<trans.Length;i++)
		{
			trans[i].GetComponentInChildren<Transform>();
		}
		//Fill all primary positions and rotations
			for(int i=0;i<trans.Length;i++)
			{
				pos[i]=trans[i].position;
				rotation[i]=trans[i].eulerAngles;
			}
			
	}
	
	// Update is called once per frame
void Update ()
 {
		//checking the change of the pos and rot 
			for(int i=0;i<pos.Length;i++)
			{
				if(trans[i].position!= pos[i])
				{
					PosndRot=false;
					break;
				}	
				else
				{
					PosndRot=true;
					
				}
			}

	}
}
