using UnityEngine;
using System.Collections;

public class VaihdaScne : MonoBehaviour {

	public void ChangeToScene(string scene){

		Application.LoadLevel (scene);
	}
}
