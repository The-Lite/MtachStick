using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinObject : MonoBehaviour {
	public bool Correct=false;
	[SerializeField]
	Transform obj;


	
	// Update is called once per frame
void OnTriggerStay2D(Collider2D	 coll)
	{
		if(coll.gameObject.layer==8)
	
		{
		//see the documentation 	
			Vector3 a = new Vector3(0,0,180);
				if(obj.eulerAngles== a)
				{
					
						Correct=true;
				}
		}

	}
}
