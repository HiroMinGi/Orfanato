using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta_Mama : MonoBehaviour {


	public Animator door;
	public Animator mama;


	// Use this for initialization
	void Start () 
	{
		

	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider kol)

	{

		if (kol.tag == "Player") 
		{
			
			door.SetBool ("Mama",true);
			mama.SetBool ("MamaGo", true);

		}
	}
}
