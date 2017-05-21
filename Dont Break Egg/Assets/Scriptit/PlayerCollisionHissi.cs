using UnityEngine;
using System.Collections;

public class PlayerCollisionHissi : MonoBehaviour {

    private bool annaPiste = false;

    public bool pelaajaYli = false;

    public float aikaTuhota;

    public bool tuhoa = false;

    public bool PelaajaOsuu = false;

    public GameObject pelaaja;

    private float pudotus;

    private float PudotusPiste;
    public float OsumisPiste;

    private GameObject alas;
	// Use this for initialization

    public float vali = 1.2f;
	void Start () {
        alas = GameObject.FindGameObjectWithTag("Alas");

	pelaaja =GameObject.FindGameObjectWithTag("pelaaja");
	}

    void OnCollisionEnter2D(Collision2D coll) {

        if (coll.gameObject.tag == "pelaaja") {
       //     createHissit.GetComponent<CreateHissit>().osuu = true;

           pelaaja.GetComponent<Collision>().osumisPiste = gameObject.transform.position.y;

            pelaaja.GetComponent<Collision>().pelaajaOsuu = true;

            if (gameObject.tag == "Osunut")
            {

            }
            else
            {
                PelaajaOsuu = true;
            }
           
            gameObject.tag = "Osunut";

         //  OsumisPiste = pelaaja.GetComponent<Transform>().position.y;
  
          
        }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
       
        if (coll.gameObject.tag == "pelaaja")
        {
            pelaaja.GetComponent<Collision>().pudotusPiste = gameObject.transform.position.y;
            pelaaja.GetComponent<Collision>().pelaajaOsuu = false;
          //  gameObject.tag = "kaytetty";
         //   pelaaja.GetComponent<Collision>().pudotusPiste = pelaaja.transform.position.y;
           if (pelaajaYli == true)
         {
       
                gameObject.tag = "kaytetty";
                pelaajaYli = false;
                aikaTuhota = 2f;
                tuhoa = true;
            }
                /**
            else {
              //  gameObject.tag = "Osunut";
            }
           
           if (alas.GetComponent<MoveWithButtons>().alasDown == true)
           {
            //   gameObject.tag = "Osunut";
           }
           else if (alas.GetComponent<MoveWithButtons>().ylosDown == true) {
           
           }
           else
           {
               aikaTuhota = 2f;
               PelaajaOsuu = false;
               gameObject.tag = "kaytetty";
               tuhoa = true;
           }
       */
            /////////////////7

         //   gameObject.tag = "hissi";
       //     Debug.Log("Pelaajan x: "+pelaaja.GetComponent<Transform>().position.x);
       //     Debug.Log("Hissin x: " + gameObject.transform.position.x + 2.9);
/**
            if (gameObject.transform.position.y - pelaaja.GetComponent<Transform>().position.y <= gameObject.transform.position.y- vali)
            {

                gameObject.tag = "Osunut";
                Debug.Log(gameObject.transform.position.y - pelaaja.GetComponent<Transform>().position.y+" väli");
                Debug.Log(gameObject.transform.position.y - vali+" tietty väli");
            }
            else {
                gameObject.tag = "hissi";
                Debug.Log(gameObject.transform.position.y - pelaaja.GetComponent<Transform>().position.y + " väli");
                Debug.Log(gameObject.transform.position.y - vali + " tietty väli");
            }
              
           */
            // LISÄÄ GAMEOBJECTIN PERÄÄN SEN X:n PITUUS /2 määrä, pelaajan x position menee gameobjectin puolessa välissä
        //   if (pelaaja.GetComponent<Transform>().position.x > gameObject.transform.position.x+2.9)
        //    {
            //    PudotusPiste = pelaaja.GetComponent<Transform>().position.y;
           //    Debug.Log(PudotusPiste + " pudotuspiste");
           

     //     }
        }
    }
	// Update is called once per frame
	void Update () {
    //    if (pudotus <= vali) {
       //     pelaaja.GetComponent<Collision>().Havisit();
       //     Debug.Log("HÄVIIIIIIISIT");
     //   }
    //    Debug.Log(pelaaja.GetComponent<Transform>().position.y - gameObject.transform.position.y + " väli");
        aikaTuhota -= Time.deltaTime;

        if (aikaTuhota <= 0) {

            aikaTuhota = 0;

        }

        if (pelaaja.transform.position.x > transform.position.x + 4)
        {
           
            Destroy(gameObject);
            pelaajaYli = true;
            aikaTuhota = 2f;
            tuhoa = true;
            if (aikaTuhota == 0 && tuhoa == true)
            {

                Destroy(gameObject);
                tuhoa = false;
            }
        }
     //   else {
     //       gameObject.tag = "Osunut";
     //   }
	}
}
