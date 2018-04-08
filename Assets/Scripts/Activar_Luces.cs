using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Luces : MonoBehaviour {

    public Animator luces;
    public GameObject creppy;
    public GameObject Flor;
	public AudioSource Suspense;
	public float mySlider;
	public AudioSource Violin;
	public float mySliderVio;
    private int contar;

	// Use this for initialization
	void Start ()
    {
        
        //creppy.SetActive(false);
        contar = 0;
		mySlider = 0f;
		mySliderVio = 0.06f;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider kol)
    {
        if (kol.gameObject.tag == "Player")
        {
            luces.SetBool("On", true);
            contar = contar + 1;
			Suspense.Play ();
			mySlider = 0.02f;
			mySliderVio = 0.03f;
			Suspense.volume = mySlider;
			Violin.volume = mySliderVio;

        }

        if (contar >= 2)
        {
            creppy.SetActive(true);
            Flor.SetActive(false);
			mySlider = 0.06f;
			mySliderVio = 0f;
			Destroy (GetComponent<BoxCollider>());
        }
	}
}
