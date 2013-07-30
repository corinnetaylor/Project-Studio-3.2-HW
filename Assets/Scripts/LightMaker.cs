using UnityEngine;
using System.Collections;

public class LightMaker : MonoBehaviour {
	
	public Light theLight;
	//int colorPicker = 0; unnecessary
	bool keyDown = false;
	
	// Use this for initialization
	void Start () {
		//theLight.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {		
		/* Old logic chain used the superfluous variable colorPicker
		Debug.Log (keyDown);
		if (Input.GetKey(KeyCode.Q)){
			colorPicker = 1;
			keyDown = true;
			
		} else if (Input.GetKey(KeyCode.W)){
			colorPicker = 2;
			keyDown = true;
			
		} else if (Input.GetKey(KeyCode.E)){
			colorPicker = 3;
			keyDown = true;
			
		} else if (Input.GetKey(KeyCode.R)){
			colorPicker = 4;
			keyDown = true;
		} else {
			colorPicker = 0;
			keyDown = false;
			
		}
		*/
		if (Input.GetKey(KeyCode.Q)){
			theLight.color = Color.red;
			keyDown = true;
			
		} else if (Input.GetKey(KeyCode.W)){
			theLight.color = Color.blue;
			keyDown = true;
			
		} else if (Input.GetKey(KeyCode.E)){
			theLight.color = Color.green;
			keyDown = true;
			
		} else if (Input.GetKey(KeyCode.R)){
			theLight.color = Color.yellow;
			keyDown = true;
		} else {
			//colorPicker = 0;
			keyDown = false;
			
		}
		
		if (Input.GetMouseButton(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//RaycastHit rayHit = new RaycastHit();
			
			if (Physics.Raycast(ray, /*out rayHit, */1000f)){ //the 'out' command tells unity to populate the variable rayHit with data 
				
//				theLight.enabled = true; //this line makes things work
				
				if (keyDown){
					//setLightColor (); Color changing is handled above in update
					theLight.enabled = true;
					theLight.transform.rotation = Quaternion.LookRotation(ray.direction);
					//theLight.transform.position = rayHit.point;
				}
				
			}
		} else {
			theLight.enabled = false;	
		}
	}
	
	/*This method is unnecessary while color is changed dynamically in Update()
	void setLightColor(){
		
		switch(colorPicker){
		case 1: theLight.color = Color.red;
			break;
		case 2: theLight.color = Color.blue;
			break;
		case 3: theLight.color = Color.green;
			break;
		case 4: theLight.color = Color.yellow;
			break;
		}
		
		
	}
	*/
}
