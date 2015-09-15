using UnityEngine;
using System.Collections;

public class KillOtherObject : MonoBehaviour {

//	void OnTriggerExit(Collider otherObject) {
//		Destroy (otherObject.gameObject);
//		Debug.Log ("trigger working");

//	}

	void OnTriggerExit(Collider otherObject) {
		if(otherObject.gameObject.tag == "pills") {
		Destroy(otherObject.gameObject);
	}

}

}
