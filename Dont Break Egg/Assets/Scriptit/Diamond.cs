using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Diamond : MonoBehaviour {

    private GameObject pelaaja;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        pelaaja = GameObject.FindGameObjectWithTag("pelaaja");

        if (transform.position.x < pelaaja.gameObject.transform.position.x - 3) {
            //JumpPanel.SetActive(true);
            Destroy(gameObject, 2f);
        }
	}
}
