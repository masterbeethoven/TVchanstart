using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {
	

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
		GUI.Box(new Rect(100, 100, 300, 100), "Left, right, up, down \n Is how you will get all around \n Are there friends who exist in this plane land \n Or are there only foes who will leave you banned\n Space to save player position "); {
		
			//print ("You clicked the button!");
		}
	}
}
