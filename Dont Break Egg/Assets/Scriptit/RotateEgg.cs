using UnityEngine;
using System.Collections;

public class RotateEgg : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

       // transform.Rotate(Vector3.right * Time.deltaTime);
        gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
	}
}
