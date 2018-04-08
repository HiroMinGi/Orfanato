using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Pelota : MonoBehaviour {

	public GameObject MovPelota;

	// Use this for initialization
	void Start () 
	{
		MovPelota.SetActive (false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider kol)
	{
		if (kol.tag == "Kick") 
		{
			MovPelota.SetActive (true);
		}
	}
}
