using UnityEngine;
using System.Collections;

public class FastScript : MonoBehaviour {

	public float InitialSpeed= 1.0f; 

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.FindWithTag("Fast")){
			if (Input.GetKey(KeyCode.RightArrow))
			{
				rigidbody.AddForce(Vector3.right*10);
				//transform.position += rightmove * Time.deltaTime; 
			}

		}


	
	}

	/*void OnCollisionEnter(Collision collision){
		if(GameObject.FindWithTag("Fast")){
			//Debug.Log ("works");
			rigidbody.AddForce(Vector3.back*10);
			rigidbody.AddForce(Vector3.forward*10);
			rigidbody.AddForce(Vector3.right*10);
			rigidbody.AddForce(Vector3.left*10);

		}

	}*/


}
