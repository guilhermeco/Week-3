using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Random working");
		GetComponent<Rigidbody> ().AddForce (Random.insideUnitSphere * 1000);
	}
}
