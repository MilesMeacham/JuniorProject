﻿using UnityEngine;
using System.Collections;

public class CharacterGravity : MonoBehaviour {
	
	public Attractor attractor;
	GameObject startPlanet;
	
	private Transform myTransform;
	
	// Use this for initialization
	void Start () {
		startPlanet = GameObject.Find ("Planet");
		attractor = startPlanet.GetComponent<Attractor>();
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
		GetComponent<Rigidbody> ().useGravity = false;
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		attractor.Attract (myTransform);
	}
	
/*	public void ChangeGravity (Collider other) {
		attractor = other.gameObject.GetComponent<Attractor>();
		
		
		
	}
*/	
}
