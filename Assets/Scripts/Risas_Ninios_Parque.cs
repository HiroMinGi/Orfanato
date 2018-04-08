using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Risas_Ninios_Parque : MonoBehaviour {

	private AudioSource  Risas;

	// Use this for initialization
	void Start () 
	{
		Risas = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider kol)
	{
		if (kol.tag == "Player") 
		{
			Risas.Play ();
		}
		
	}
	void OnTriggerExit (Collider kol)
	{
		if (kol.tag == "Player") 
		{
			Risas.Stop ();
		}
	}
}
