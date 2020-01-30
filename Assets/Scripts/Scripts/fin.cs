using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin : MonoBehaviour {

	public GameObject bus;
	public float speed;
	// Use this for initialization
	void OnTriggerStay(Collider other)
	{
        if(other.transform.name == "Terrain")
        {

			Destroy(this.gameObject);
		}
	}

	// Update is called once per frame

}
