using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour {
	
	public GameObject Key;
	public GameObject mamaActivar;

	// Use this for initialization
	void Start ()
	{
		mamaActivar.SetActive (false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider kol)
	{
		if (kol.tag == "Player") 
		{
			Key.SetActive (false);
			mamaActivar.SetActive (true);
		}
		
	}
}
