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
		GUI.Box(new Rect(100, 100, 300, 50), "They don't like it when you have friends,\n as random as they are."); {
			//print ("You clicked the button!");
		}
	}
}
