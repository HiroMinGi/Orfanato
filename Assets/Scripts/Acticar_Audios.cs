using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acticar_Audios : MonoBehaviour {

	public AudioSource iris;
	public AudioSource jardin;
	public AudioSource puertaJardin;
	public AudioSource dayannaJardin;
    public AudioSource QueOcurre;
	public AudioSource Risas;
	public AudioSource DondeEstan;
	public AudioSource Grito01;
	public AudioSource Mama;
	public AudioSource Grito02;
	public AudioSource Grito03;
	public AudioSource Suspenso;
	public AudioSource Risas2;
	public AudioSource RuidoMama;
	public AudioSource pelota;
	public AudioSource niniaFinal;

	void OnTriggerEnter (Collider kol)
	{
		if (kol.gameObject.tag == "Iris") {
			iris.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "Jardin") {
			jardin.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "Dayanna") {
			dayannaJardin.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "PuertaJardin") {
			puertaJardin.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "QueOcurre") {
			QueOcurre.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "Risas") {
			Risas.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}
		if (kol.tag == "DondeEstan") {
			DondeEstan.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "Girto1") {
			Grito01.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "Mama") {
			Mama.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "Grito2") {
			Grito02.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "Grito3") {
			Grito03.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "Suspenso") {
			Suspenso.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "RisasJardin") {
			Risas2.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "RuidoMama") 
		{
			RuidoMama.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}
		if (kol.tag == "Pelota") 
		{
			pelota.Play ();
			Destroy (kol.GetComponent<BoxCollider> ());
		}

		if (kol.tag == "NiniaFinal") 
		{
			niniaFinal.Play ();

		}
	}
}
