using UnityEngine;
using System.Collections;

public class RandomObjects : MonoBehaviour {
	
	public Transform littleboxes;
	public int numToSpawn;
	public Vector3 position;
	
	void Awake()
	{
		Vector3 position = new Vector3(Random.Range(10.0F, 15.0F), 70, Random.Range(10.0F, 15.0F));
	}
	
	void Start() 
	{
		int spawned = 0;
		
		while (spawned < numToSpawn)
		{
			position = new Vector3(Random.Range(10.0F, 15.0F), 70, Random.Range(10.0F, 15.0F));
			Instantiate(littleboxes, position, Quaternion.identity);
			spawned++;
		}
	}
	

	
}