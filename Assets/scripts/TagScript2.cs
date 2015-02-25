using UnityEngine;
using System.Collections;

public class TagScript2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(GameObject.FindWithTag("Foe") == null){
			//GameObject.Find ("Timer").SendMessage("EndGame");
			Application.LoadLevel("EndGame");
		}
		
		if(GameObject.FindWithTag("Friend") == null){
			//GameObject.Find ("Timer").SendMessage("EndGame");
			Application.LoadLevel("EndGame");

			//Application.LoadLevel("morefriendslvl");
		}
		
		//if(Input.GetMouseButtonDown(0)){
		//	Application.LoadLevel("morefriendslvl");
		//}
		
		
	}
}
