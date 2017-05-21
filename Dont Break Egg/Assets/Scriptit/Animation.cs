using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {

    public GameObject pelaaja;
  //  Animator anim;
    private bool tosi = false;
     Animator anim;
	// Use this for initialization
	void Start () {
     //   anim = GetComponent<Animator>();
      //   tosi = anim.GetBool((Animator.StringToHash("Break")));

     anim = GetComponent<Animator>();

        }
	
	// Update is called once per frame
	void Update () {
        
      //  if (Input.GetKeyDown(KeyCode.A))
        if (pelaaja.GetComponent<Collision>().havisitBool == true)
        {
       
            anim.SetBool("Break", true);
        }
        else {

            anim.SetBool("Break", false);
        }
	}
}
