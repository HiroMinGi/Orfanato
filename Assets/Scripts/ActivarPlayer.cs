using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPlayer : MonoBehaviour {
	

	public GameObject Plano;
	public GameObject Playerr;


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Plano==false) 
		{
			Playerr.SetActive (true);
		}


	}
}
