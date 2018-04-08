using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador_PuertaCorredor : MonoBehaviour {

    public GameObject colliderCorredor;

	// Use this for initialization
	void Start ()
    {
        colliderCorredor.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider kol)
    {
        if (kol.gameObject.tag == "Player")
        {
            colliderCorredor.SetActive(true);
        }
	}

    void OnTriggerExit(Collider kol)
    {
        if (kol.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
