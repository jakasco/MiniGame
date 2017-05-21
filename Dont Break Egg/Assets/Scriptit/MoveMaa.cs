using UnityEngine;
using System.Collections;

public class MoveMaa : MonoBehaviour {

    public GameObject pelaaja;

    public GameObject hissi;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        hissi = GameObject.FindGameObjectWithTag("hissi");

        Vector3 temp = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

       temp.x = pelaaja.gameObject.transform.position.x;
       temp.y = hissi.gameObject.transform.position.y - 10;
       gameObject.transform.position = temp;
	}
}
