using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Objetos_Anim : MonoBehaviour {

	public Animator Oso;
	public Animator MotoMov;
	public GameObject niniaJardin;

	void Start ()
	{
		niniaJardin.SetActive (false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider kol) 
	{
		if (kol.tag == "Oso") 
		{
			Oso.SetBool ("Caer", true);
		}	

		if (kol.tag == "MotoMov") 
		{
			niniaJardin.SetActive (true);
			MotoMov.SetBool ("Balancear", true);
		}
	}

	void OnTriggerExit (Collider kol)
	{
		if (kol.tag == "MotoMov") 
		{
			Destroy (niniaJardin);
		}
	}
}
