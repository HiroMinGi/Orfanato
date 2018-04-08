using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {

	public GameObject pelota;
	public GameObject jugador;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		pelota.transform.Translate (Vector3.forward*Time.deltaTime,jugador.transform);
	}
}
