using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GemController : MonoBehaviour {

    public GameObject noGem;

    public Text amountOfGems;

    public int gemMaara = 2;

    public GameObject useGemButton;

    public GameObject menu;
	// Use this for initialization
	void Start () {
        noGem.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        string maara = gemMaara.ToString() + "x";
        Debug.Log(maara);
        amountOfGems.text = maara;

        if (gemMaara <= 0)
        {

            gemMaara = 0;
            noGem.SetActive(true);
            useGemButton.SetActive(false);
        }
        else {
            noGem.SetActive(false);
            useGemButton.SetActive(true);
                
        }

	}
}
