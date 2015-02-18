using UnityEngine;
using System.Collections;

public class DontDestroyMusicScript : MonoBehaviour {

void Awake(){
//		//continue music script...
		DontDestroyOnLoad(this.gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
