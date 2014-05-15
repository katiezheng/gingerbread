using UnityEngine;
using System.Collections;

public class colorchange3 : MonoBehaviour 
{
	
	int counter=0;
	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown (0))
			counter = counter + 1;
		
	}
	void Update(){
		if (counter==0)
			renderer.material.color = Color.white;
		if (counter==1)
			renderer.material.color = Color.red;
		if (counter==2)
			renderer.material.color = Color.green;
		if (counter==3)
			renderer.material.color = Color.white;
		if (counter==4)
			renderer.material.color = Color.yellow;
		if (counter==5)
			renderer.material.color = Color.black;
		if (counter==6)
			renderer.material.color = Color.magenta;
		if (counter==7)
			renderer.material.color = Color.clear;
		if (counter==8)
			renderer.material.color = Color.blue;
		if (counter==9)
			renderer.material.color = Color.red;
		if (counter==10)
			renderer.material.color = Color.green;
		if (counter==11)
			renderer.material.color = Color.white;
		if (counter==12)
			renderer.material.color = Color.yellow;
		if (counter==13)
			renderer.material.color = Color.black;
		if (counter==14)
			renderer.material.color = Color.magenta;
		if (counter==15)
			renderer.material.color = Color.clear;
	}
}