using UnityEngine;
using System.Collections;

public class Level2InstructionsScript : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	//IEnumerator What(){
	//print(Time.time);
	//yield return new WaitForSeconds(5);
	//print(Time.time);
	//}
	
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 10);
	}
	
	void OnGUI () {
		GUI.Box(new Rect(100, 100, 300, 100), "There are more of them now... "); {
			//print ("You clicked the button!");
		}
	}
}
