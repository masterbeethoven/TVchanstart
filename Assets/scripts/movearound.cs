using UnityEngine;
using System.Collections;

public class movearound : MonoBehaviour {
	
	//creating vectors for movement 
	//Vector3 rightmove = new Vector3 (10f, 0f, 0f);
	//Vector3 leftmove = new Vector3 (-10f, 0f, 0f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow))
		{
			rigidbody.AddForce(Vector3.right);
			//transform.position += rightmove * Time.deltaTime; 
		}
	
		//}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rigidbody.AddForce(Vector3.left);
		}
		
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rigidbody.AddForce(Vector3.forward);
		}
		
		if (Input.GetKey(KeyCode.DownArrow))
		{
			rigidbody.AddForce(Vector3.back);
		}
		
	
	}


}