using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {

    public GameObject hissi;

    public float nopeus = 2f;

    private bool ylos = false;

    private bool alas = false;
	// Use this for initialization
	void Start () {
	
	}

   public  void Ylos() {
        ylos = true;
        alas = false;
    }

    public void Alas() {
        alas = true;
        ylos = false;
    }
	// Update is called once per frame
	void Update () {

        if (ylos == true)
        {
            hissi.transform.Translate(Vector3.up * nopeus * Time.deltaTime);
        }
        

        if (alas == true)
        {
            hissi.transform.Translate(Vector3.down * nopeus * Time.deltaTime);
        }
	}
}
