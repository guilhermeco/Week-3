using UnityEngine;
using System.Collections;

public class makeapill : MonoBehaviour {
	
	public GameObject Spawner;
	public GameObject TestSphere;

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.G)) {
//			Instantiate(gameObject, Vector3 position, Quaternion rotation);
			Instantiate(Spawner, transform.position, transform.rotation);
			Instantiate(TestSphere, transform.position, transform.rotation);


		}
	}
}