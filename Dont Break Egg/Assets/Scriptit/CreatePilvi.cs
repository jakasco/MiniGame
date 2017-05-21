using UnityEngine;
using System.Collections;

public class CreatePilvi : MonoBehaviour {

    public GameObject pilvi1;

    public GameObject pilvi2;

    public GameObject pilvi3;

    public GameObject pelaaja;

    private GameObject tempPilvi;

    public float CreationTime = 3f;

    public float createTime;

    private int zPituus = 2;
	// Use this for initialization
	void Start () {
        createTime = CreationTime;
	}
	
	// Update is called once per frame
	void Update () {

        int ra = UnityEngine.Random.Range(0, 3);

        int RandomKorkeus = UnityEngine.Random.Range(-10, 10);

        if (ra == 0) {

            tempPilvi = pilvi1;

            zPituus = 2;
        }
        if (ra == 1)
        {

            tempPilvi = pilvi2;

            zPituus = 3;
        }
        if (ra == 2)
        {

            tempPilvi = pilvi3;

            zPituus = 4;
        }
     

        createTime -= Time.deltaTime;

        if (createTime <= 0)
        {
            createTime = 0;

            Instantiate(tempPilvi, new Vector3(pelaaja.gameObject.transform.position.x+15, pelaaja.gameObject.transform.position.y+RandomKorkeus, pelaaja.gameObject.transform.position.z + zPituus), Quaternion.identity);

            createTime = CreationTime;
        }
	}
}
