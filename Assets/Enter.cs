using UnityEngine;
using System.Collections;
using Invector;

public class Enter : MonoBehaviour {

	void OnStart (){
	//	GameObject.Find("CarCamera").SetActive(false);
	//	GameObject.Find ("CarCamera").GetComponent<v3rdPersonCamera> ().enabled = false;
	}
	void OnTriggerEnter (Collider col) {
		Debug.Log ("Player In Trigger");
		if (col.tag == "Player") {
			GameObject.Find("Camera").SetActive(false);
			GameObject.Find("CarCamera").SetActive(true);
			//GameObject.Find ("CarCamera").GetComponent<v3rdPersonCamera> ().enabled = true;
			//MonoBehaviour cont = col.GetComponent<vThirdPersonController>();
			//cont.enabled = false;
			col.enabled=false;
			GameObject.Find ("CXmazdaside(2)").GetComponent<CharacterController> ().enabled = true;
		}

	}
}
