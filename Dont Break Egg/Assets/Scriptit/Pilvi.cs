using UnityEngine;
using System.Collections;

public class Pilvi : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        GameObject pelaaja = GameObject.FindGameObjectWithTag("pelaaja");

        if (gameObject.transform.position.x < pelaaja.gameObject.transform.position.x - 15)
        {

            Destroy(gameObject);

        }
	}
}
