using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Menu : MonoBehaviour {

    public Text aikaText;

    public GameObject ContinuePanel; 

    public GameObject GemController;

    public GameObject osunut;

    public GameObject pelaaja;

    public GameObject menu;

    public GameObject HavisitMenu;

    public bool pause = false;

    private float aika;

    private int aikaInt;

	// Use this for initialization
	void Start () {
        ContinuePanel.SetActive(false);
        menu.SetActive(false);
        HavisitMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        aikaText.text = aikaInt.ToString();

        aika -= Time.deltaTime;
        aikaInt = (int)aika;
        if (aika <= 0)
        {

            aika = 0;
            ContinuePanel.SetActive(false);
         
            pelaaja.GetComponent<MoveEgg>().nopeus = 3f;
        }
        else {

            Vector3 temp = pelaaja.gameObject.transform.position;

            temp.x = osunut.transform.position.x;
            temp.y = osunut.transform.position.y + 1.3f;
            temp.z = osunut.transform.position.z;

            pelaaja.gameObject.transform.position = temp;
        }

        osunut = GameObject.FindGameObjectWithTag("Osunut");

        if (pause == true)
        {
            Time.timeScale = 0;
        }
        else {
            Time.timeScale = 1;
        }
	}

    public void AvaaMenu() {

        menu.SetActive(true);

        pause = true;
    }

    public void SuljeMenu() {

        menu.SetActive(false);

        pause = false;
    }

    public void AvaaHavisitMenu() {

        HavisitMenu.SetActive(true);

        pause = true;
    }

    public void SuljeHavisitMenu() {


        pause = false;

        GemController.GetComponent<GemController>().gemMaara -= 1;

        Debug.Log("SULE MENU NAPPI TOIMII?????????");

        HavisitMenu.SetActive(false);


        pelaaja.GetComponent<Collision>().osumisPiste = 0;

        pelaaja.GetComponent<Collision>().pudotusPiste = 0;

        pelaaja.GetComponent<Collision>().aikaRetry = 0.3f;

        pelaaja.GetComponent<Collision>().havisitKerran = true;

        pelaaja.GetComponent<Collision>().havisitBool = false;

        //asetetaan pelaaj osuneen päälle
        Vector3 temp = pelaaja.gameObject.transform.position;

        temp.x = osunut.transform.position.x;
        temp.y = osunut.transform.position.y+1;
        temp.z = osunut.transform.position.z;

        pelaaja.gameObject.transform.position = temp;

        ContinuePanel.SetActive(true);
        aika = 3f;
    }


}
