using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninia_Mov : MonoBehaviour {

	public GameObject Ninia;
	public float Speed;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Ninia.transform.Translate (0, 0,Speed* Time.deltaTime);
	}
}
