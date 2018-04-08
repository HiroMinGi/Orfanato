using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Door : MonoBehaviour {

	public Animator anim;
	public AudioSource Open;
	public AudioSource Close;

	// Use this for initialization
	void Start ()
	{
		

	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col) 
	{
		if (col.tag == "Player") 
		{
			anim.SetBool ("Open", true);
			anim.SetBool ("Close", false);
			Open.Play (1);
		}
	}

	void OnTriggerExit (Collider col)
	{
		anim.SetBool ("Close", true);
		anim.SetBool ("Open", false);
		Close.Play (1);
	
	}
}
