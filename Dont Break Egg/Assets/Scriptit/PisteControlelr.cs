using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PisteControlelr : MonoBehaviour {


    public Text PisteText;

    public GameObject createHissit;

    public float pisteet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        pisteet = createHissit.GetComponent<CreateHissit>().pisteet;

        PisteText.text = pisteet.ToString();

	}
}
