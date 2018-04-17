﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformButton : MonoBehaviour
{
	
	//components & variables
	public bool ispressed = false;

	private Vector3 posA;

	private Vector3 posB;

	private Vector3 nextPos;

	public GameObject button;


	[SerializeField]
	private float speed;

	[SerializeField]
	private Transform childTransform;

	[SerializeField]
	private Transform transformB;
	// Use this for initialization
	void Start ()
	{
		posA = childTransform.localPosition;
		posB = transformB.localPosition;
		nextPos = posB;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(ispressed)
			Move ();

	}

	public void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Box") {
			ispressed = true;
		} else
			ispressed = false;
	}

	private void Move ()
	{
		childTransform.localPosition = Vector3.MoveTowards (childTransform.localPosition, nextPos, speed * Time.deltaTime);
		if (Vector3.Distance (childTransform.localPosition, nextPos) <= 0.1) {
			ChangeDestination ();
		}
	}

	private void ChangeDestination ()
	{
		nextPos = nextPos != posA ? posA : posB;
	}
}
