using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Exit : MonoBehaviour {

    public GameObject ExitPanel;
	// Use this for initialization
	void Start () {
        ExitPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void avaaExit() {
        ExitPanel.SetActive(true);
    }

    public void suljeExit() {

        ExitPanel.SetActive(false);
    }
}
