using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Ninios : MonoBehaviour {

	public Animator Run;
	public GameObject activMovNinia;
	public GameObject ninia;
	public Animator Crawl;
	public GameObject activModelNinia;
	public Animator AcMama;
	public GameObject mama;
	public Animator bum;

	//public GameObject niniaCaer;
	//public Animator Go;
	public Animator pelota;
	//public Animator kick;
	//public GameObject NiniaKick;


	// Use this for initialization
	void Start ()
	{
		ninia.SetActive (false);
		activModelNinia.SetActive (false);
		mama.SetActive (false);
		//niniaCaer.SetActive (false);
		//NiniaKick.SetActive (false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider kol)
	{
		if (kol.tag == "Run") 
		{
			ninia.SetActive (true);
			Run.SetBool ("Run", true);
			activMovNinia.SetActive (true);
			Destroy (ninia,1f);
		}

		if (kol.tag == "Crawl") 
		{
			activModelNinia.SetActive (true);
			Crawl.SetBool ("Arrastrar", true);
			Destroy (activMovNinia,0.5f);

		}

		if (kol.tag == "Kick") 
		{
			pelota.SetBool("Rodar",true);
		    //NiniaKick.SetActive (true);
		}

		if (kol.tag == "Mama") 
		{
			AcMama.SetBool ("MamaGo", true);
			mama.SetActive (true);
		}

	
	}
	void OnTriggerExit(Collider kol)
	{
		if (kol.tag == "Kick")
		{
			bum.SetBool ("Bum", true);
		}
	}
}
