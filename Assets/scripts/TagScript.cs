using UnityEngine;
using System.Collections;

public class TagScript : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		
		if(GameObject.FindWithTag("Foe") == null){
			Application.LoadLevel("morefriendslvl");
		}
		
		if(GameObject.FindWithTag("Friend") == null){
			Application.LoadLevel("morefriendslvl");
		}

		//if(Input.GetMouseButtonDown(0)){
		//	Application.LoadLevel("morefriendslvl");
		//}
	
	
	}
}
