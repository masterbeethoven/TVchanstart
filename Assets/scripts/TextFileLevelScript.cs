using UnityEngine;
using System.Collections;
using System.IO;

public class TextFileLevelScript : MonoBehaviour {
	
	public string fileName;
	
	//public string[] level;
	
	public float offsetX;
	public float offsetY;
	
	// Use this for initialization
	void Start () {
		
		StreamReader reader = new StreamReader (fileName);
		
		string contentOfFile = reader.ReadToEnd ();  
		
		reader.Close ();
		
		char[] newLineChar = {'\n'};
		
		string[] level = contentOfFile.Split (newLineChar);
		
		for (int y = 0; y < level.Length; y++) {
			MakeRow (level [y], -y);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void MakeRow(string rowStr, float y){
		char[] rowArray = rowStr.ToCharArray ();
		
		for (int i = 0; i < rowStr.Length; i++) {
			char c = rowArray[i];
			
			if(c == 'X'){
				GameObject brick = Instantiate(Resources.Load("IOFriend")) as GameObject;
				brick.transform.position = new Vector3(
					i * brick.transform.localScale.x + offsetX, 
					y * brick.transform.localScale.y + offsetY, 
					0);
			} 

			/*else if (c == 'S'){
				GameObject sphere = Instantiate(Resources.Load("Sphere")) as GameObject;
				sphere.transform.position = new Vector3(
					i * sphere.transform.localScale.x + offsetX, 
					y * sphere.transform.localScale.y + offsetY, 
					0);
			} else if (c == 'C'){
				GameObject cyl = Instantiate(Resources.Load("Cylinder")) as GameObject;
				cyl.transform.position = new Vector3(
					i * cyl.transform.localScale.x + offsetX, 
					y * cyl.transform.localScale.y + offsetY, 
					0);
			}*/
		}
	}
}
