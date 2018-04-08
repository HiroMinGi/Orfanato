using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Inicio : MonoBehaviour {

	public Material colorInicio;
	public float speedFade;
	private float alpha = 1.0f;
   // public FogMode fade;

	// Use this for initialization
	void Start ()
    {
        //RenderSettings.fogEndDistance = 100;
    }
	
	// Update is called once per frame
	void Update ()
	{
        //RenderSettings.fogEndDistance = 1000;
           // alpha -= speedFade * Time.deltaTime;

		colorInicio.color = new Color (0, 0, 0, alpha);
		alpha -= speedFade *Time.deltaTime;
		if (alpha <= 0) 
		{
			Destroy (this.gameObject);
		}
	}
}
