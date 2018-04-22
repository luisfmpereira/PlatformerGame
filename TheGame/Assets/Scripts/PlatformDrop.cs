﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour {

	public GameObject platform;



	void OnTriggerStay2D(Collider2D hit){

		if (hit.gameObject.CompareTag ("Player") && Input.GetKey (KeyCode.Space) && Input.GetKey (KeyCode.LeftControl) ){

			platform.GetComponent<BoxCollider2D> ().isTrigger = true;
		}


	}


}