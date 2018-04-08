using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour {

	public Transform traget;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Uptade () 
	{ 
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, traget.position, step);
		
	}

}
