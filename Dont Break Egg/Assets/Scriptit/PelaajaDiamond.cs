using UnityEngine;
using System.Collections;

public class PelaajaDiamond : MonoBehaviour {

    public bool hyppyBool = false;

    public GameObject Timantti;

    public GameObject jumpPanel;
	// Update is called once per frame
	void Update () {

        Timantti = GameObject.FindGameObjectWithTag("timantti");

        if (transform.position.x < Timantti.gameObject.transform.position.x+2)
        {
            /**
            if (gameObject.GetComponent<MoveEgg>().jumpSwitch == true)
            {
                hyppyBool = true;
            }
            else {
                hyppyBool = false;

            }
             * */

            if (hyppyBool == true)
            {
               
                jumpPanel.SetActive(true);
            }
        }
        else {
            jumpPanel.SetActive(false);
        }
	}
}
