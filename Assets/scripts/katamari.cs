using UnityEngine;
using System.Collections;

public class katamari : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision other) {
		
		if(other.gameObject.tag != "Sphere")
		{
			Attach(other);
		}
		
	}
	
	void Attach (Collision other)
	{
		if(other.gameObject.GetComponent("Rigidbody") != null)
		{
			Destroy(other.gameObject.rigidbody);
			other.transform.parent = transform;
		}

}
}