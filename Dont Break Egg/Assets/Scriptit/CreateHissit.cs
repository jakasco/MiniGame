using UnityEngine;
using System.Collections;



public class CreateHissit : MonoBehaviour {

  //  public GameObject hissi;
    public float loikat = 0;

    public float pisteet = 0;

    public bool tyhjaa = false;

    public bool osuu = false;

    public GameObject timantti;

    public GameObject pelaaja;

    public GameObject phrebab;

    public int random;

    public float vali = 3f;

    private Vector3 etaisyys;

    public float radius = 10f;
	// Use this for initialization
	void Start () {
       
        /**
        for (int i = 0; i < 10; i++)
        {
            int randomNum = UnityEngine.Random.Range(0, random);

            Instantiate(phrebab, new Vector3(i * vali, randomNum, 0), Quaternion.identity);
        }
         */
	}
	
	// Update is called once per frame
	void Update () {

        if (loikat >= 15) {
            loikat = 0;
            GameObject hissi = GameObject.FindGameObjectWithTag("hissi");
            Instantiate(timantti, new Vector3(hissi.gameObject.transform.position.x +1, hissi.gameObject.transform.position.y+5, pelaaja.gameObject.transform.position.z), Quaternion.identity);
           // pelaaja.GetComponent<MoveEgg>().jumpSwitch = true;
            pelaaja.GetComponent<PelaajaDiamond>().hyppyBool = true;
        }
     //   Debug.Log(osuu);
        int randomNum = UnityEngine.Random.Range(0, random);
        int PlusMinus = UnityEngine.Random.Range(0, 2);
     //   Debug.Log(PlusMinus + " 1/2");
       GameObject osunut = GameObject.FindGameObjectWithTag("Osunut");


       if (osunut.GetComponent<PlayerCollisionHissi>().PelaajaOsuu == true)
       {
           pisteet += 1;
           loikat += 1;
      
           if (PlusMinus == 0)
           {
               Instantiate(phrebab, new Vector3(osunut.gameObject.transform.position.x + 5,osunut.gameObject.transform.position.y + randomNum * -1, 0), Quaternion.identity);
           }
           else {
               Instantiate(phrebab, new Vector3(osunut.gameObject.transform.position.x + 5, osunut.gameObject.transform.position.y + randomNum-4, 0), Quaternion.identity);
           }
           osunut.GetComponent<PlayerCollisionHissi>().PelaajaOsuu = false;
       }
	}
}
