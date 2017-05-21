using UnityEngine;
using System.Collections;

public class BGFollowPlayer : MonoBehaviour {

    public GameObject pelaaja;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 playerPos = new Vector3(pelaaja.gameObject.transform.position.x, pelaaja.gameObject.transform.position.y, pelaaja.gameObject.transform.position.z+10);

        transform.position = playerPos;

	}
}
