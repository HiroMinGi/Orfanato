using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces_Darkz : MonoBehaviour {

	public Animator luces;


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider kol)
	{
	
		if (kol.tag == "Off") 
		{
			luces.SetBool ("Go", true);
			luces.SetBool ("On", false);

		}

		if (kol.tag == "On")
		{
			luces.SetBool ("On", true);
			luces.SetBool ("Go", false);

		}
	}
}
