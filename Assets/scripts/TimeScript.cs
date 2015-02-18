using UnityEngine;
using System.Collections;
using System.IO;

public class TimeScript : MonoBehaviour {
	public float time = 0;
	private bool isRunning = true;
	// Use this for initialization
	const string FILE_NAME = "TimeScore.txt";
	private int bestScore = 999999999; 

	void Start () {
		DontDestroyOnLoad(this.gameObject);

		StreamReader reader = new StreamReader (FILE_NAME);
		
		string content = reader.ReadLine();
		

		

		
		int bestScore = int.Parse(content);
		
		reader.Close ();
	}
	
	// Update is called once per frame
	void Update () {
		if(isRunning == true){
			time += Time.deltaTime;
			int tmpTime = (int)Mathf.Floor(time);
			this.gameObject.guiText.text = tmpTime.ToString();
		}
	}
	void EndGame(){
		//end game here
		//write the time to file
		if(isRunning == true){
			isRunning = false;
			int tmpTime = (int)Mathf.Floor(time);
			//read the file, and get the value
			if(tmpTime < bestScore){
				bestScore = tmpTime;
				StreamWriter writer = new StreamWriter(FILE_NAME, false);
				writer.Write(bestScore);
				writer.Close();
				}
			}
	}
}
