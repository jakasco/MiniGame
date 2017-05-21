using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collision : MonoBehaviour {

    public GameObject maa;

    public GameObject ButtonController;

    public GameObject hissit;

    public float pudotusTime;

    public float pudotusAika = 0.2f;

    public bool pelaajaOsuu = true;

    private float pisteTime = 0;

    public float aikaRetry = 0.3f;

    public float pudotusVali = 0;

    private GameObject alas;
    Animation anim;

    public GameObject osunut;

    public GameObject kaytetty;

    public float pudotusPiste;
    public float osumisPiste;

    public float valiTuhota;

    public float tuhoamisVali;
    public string scene;
    public bool havisitBool = false;
    public bool havisitKerran = true;

    public GameObject sceneChanger;

	// Use this for initialization
	void Start () {


        alas = GameObject.FindGameObjectWithTag("Alas");

        gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
	}

    void OnCollisionEnter2D(Collision2D coll) {

        if (coll.gameObject.tag == "hissi") {

            Debug.Log("osuu hissiin");
        
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
     //       Debug.Log("osuu");
        //    osumisPiste = gameObject.transform.position.y;
    
        }

        if (coll.gameObject.tag == "osunut")
        {
            Debug.Log("osuu osunut");
     
            osumisPiste = gameObject.transform.position.y;
            Debug.Log(osumisPiste+ " osumisPISTE");
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            
        }

    }

    void OnTriggerEnter2D(Collider2D coll) {

        if (coll.gameObject.tag == "haviaa") {

            Debug.Log("PELAAJA OSUU HAVIAA TAGIIN!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            havisitBool = true;

      //      Havisit();
        }

        if (coll.gameObject.tag == "timantti") {
            hissit.GetComponent<CreateHissit>().pisteet *= 2;
            GameObject timantti = GameObject.FindGameObjectWithTag("timantti");
            Destroy(timantti);
          
        }

      
    }

    void OnCollisionExit2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "hissi")
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            pudotusPiste = gameObject.transform.position.y;
       //     Debug.Log(pudotusPiste + " pudotusppiste");
        }

        if (coll.gameObject.tag == "osunut")
        {
            pudotusPiste = gameObject.transform.position.y;
        //    Debug.Log(pudotusPiste + " pudotusppiste");
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

        }

    }

    public void Havisit() {

            ButtonController.GetComponent<Menu>().AvaaHavisitMenu();

      //  sceneChanger.GetComponent<VaihdaScne>().ChangeToScene(scene);
    }
	// Update is called once per frame
    void Update()
    {


        osunut = GameObject.FindGameObjectWithTag("Osunut");

        kaytetty = GameObject.FindGameObjectWithTag("kaytetty");

        //   pudotusPiste = kaytetty.gameObject.transform.position.y;//osunut.GetComponent<PlayerCollisionHissi>().PudotusPiste;

        //    osumisPiste = osunut.gameObject.transform.position.y;
        //  osumisPiste = osunut.GetComponent<PlayerCollisionHissi>().OsumisPiste;
        /**
        if (osumisPiste <= 0) {
            osumisPiste = osumisPiste * -1;
        }
        if (pudotusPiste <= 0)
        {
            pudotusPiste = pudotusPiste * -1;
        }
        */
        tuhoamisVali = pudotusPiste - osumisPiste;
        /**
        if (tuhoamisVali < 0) {

            tuhoamisVali = tuhoamisVali * -1;
        }
         * */
        if (tuhoamisVali > valiTuhota)
        {

            havisitBool = true;

        }

        if (pelaajaOsuu == false)
        {

            pudotusAika -= Time.deltaTime;

            if (pudotusAika <= 0)
            {

                pudotusAika = 0;
                //   havisitBool = true;
            }
        }
        else
        {

            pudotusAika = pudotusTime;
        }
        /**
        if (gameObject.transform.position.x <= osunut.gameObject.transform.position.x + 3.9)
        {
            osunut.tag = "Osunut";
        }
          */
        //   Debug.Log(pudotusPiste - osumisPiste + " pudostusta yhteensä");

        if (transform.position.y < maa.gameObject.transform.position.y - 30) {
            havisitBool = true;
        }

        if (havisitKerran == true)
        {
            if (havisitBool == true)
            {
               
                aikaRetry -= Time.deltaTime;


                if (aikaRetry <= 0)
                {
                    Debug.Log("PUDOTUS HÄVIÖ");
                    aikaRetry = 0;
                    Havisit();
                    havisitKerran = false;
                }
            }
        }
    }
}
