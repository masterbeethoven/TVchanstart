using UnityEngine;
using System.Collections;

public class EndingWords : MonoBehaviour {
	//bool endtext=false;
	//this was supposed to show up at the end 
	//public TextMesh npcDialog;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//(Time.time >20f && endtext ==false)
		//{
			//Instantiate(GUI.Box(new Rect (100, 100, 300, 100), "test" ));
				//}
				//endtext = true;
		//npcDialog.text ="yolo"; // this goes with publicTextMesh and then you just turn off mesh in unity for 3d guitext
	
	}
	void OnGUI () {
		  GUI.Box(new Rect(100, 100, 300, 100), "text "); {
			//print ("You clicked the button!");
		}
	}
}
