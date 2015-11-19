using UnityEngine;
using System.Collections;

public class JumpThroughPlatforms : MonoBehaviour {

	public int playerLayer = 8;
	public int platformLayer = 9;
	public float playerVelocity;

	public float newPosition;
	public float oldPosition;
	public Transform rb;
	public Attractor core;
	

	// Use this for initialization
	void Start () {
		rb = GetComponent<Transform>();
		core = FindObjectOfType<Attractor>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//newPosition = rb.position.y;

		newPosition = Vector3.Distance(rb.position, core.GetComponent<Transform>().position);

		playerVelocity = newPosition - oldPosition;

		Physics.IgnoreLayerCollision(playerLayer, platformLayer, playerVelocity > 0.01f);

		oldPosition = newPosition;
	}
	
}
