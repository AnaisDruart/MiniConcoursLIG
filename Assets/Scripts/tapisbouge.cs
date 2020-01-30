using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapisbouge : MonoBehaviour {
	public GameObject TapisRoulant;
	public Transform endpoint;
	public float speed;
	// Use this for initialization
	void OnTriggerStay (Collider other) {
		other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
