using UnityEngine;
using System.Collections;

public class Charge : MonoBehaviour {

	public float chargeDistance = 10;
	public bool charging = false;
	public float chargeUpTime = 1;
	public int chargeSpeed = 10;
	private int tempSpeed;

	private Vector3 playerDistanceVector3;

	private TrackPlayer theTrackPlayer;
	private CharacterMotor2 theCharacterMotor;

	void Start ()
	{
		theTrackPlayer = gameObject.GetComponent<TrackPlayer> ();
		theCharacterMotor = gameObject.GetComponent<CharacterMotor2> ();
	}

	// Update is called once per frame
	void Update () 
	{
		playerDistanceVector3 = theTrackPlayer.frontOrBack;

		if (!charging) 
		{
			if (playerDistanceVector3.x < chargeDistance && playerDistanceVector3.x > 0 && playerDistanceVector3.y < 2.5f && playerDistanceVector3.y > -2f) 
				StartCoroutine ("ChargeCo");
		}
	}

	IEnumerator ChargeCo()
	{
		charging = true;

		float startingPoint = transform.position.x;
		bool doneCharging = false;

		// Store the speed into a variable
		tempSpeed = theCharacterMotor.speed;
		
		// Turn the speed off for the charging start up animation
		theCharacterMotor.speed = 0;
		
		yield return new WaitForSeconds (chargeUpTime);

		theCharacterMotor.speed = chargeSpeed;

		if(theCharacterMotor.movingLeft == true)
			theCharacterMotor.speed = -chargeSpeed;
		else if (theCharacterMotor.movingRight == true)
			theCharacterMotor.speed = chargeSpeed;
			
	


		yield return new WaitForSeconds (5f);
		theCharacterMotor.speed = tempSpeed;

		charging = false;
		
	}
}
