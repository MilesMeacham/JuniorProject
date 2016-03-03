using UnityEngine;
using System.Collections;
//temp audio
using FMODUnity;

public class CharacterJump2 : MonoBehaviour {

	public CharacterMotor2 theCharacterMotor;
	public GroundCheck theGroundCheck;

	//temp audio
	public StudioEventEmitter jumpSound;
	
	//jumping variables
	public bool doubleJumped;
	
	
	
	// Use this for initialization
	void Start () {
		theGroundCheck = GetComponentInChildren<GroundCheck> ();
		theCharacterMotor = GetComponent<CharacterMotor2> ();
		
	}
	
	
	void FixedUpdate () 
	{
		if(theGroundCheck.grounded)
		{
			doubleJumped = false;
		}
	}
	
	//keyboard jumping
	public void Jump () {
		if (theGroundCheck.grounded && !doubleJumped) {
			theCharacterMotor.VerticalVelocity ();
			//temp audio
			//may cause errors in enemies without emitters and fmod events
			jumpSound.Play ();
		}
		else if (!doubleJumped) 
		{
			theCharacterMotor.VerticalVelocity ();
			doubleJumped = true;
			//temp audio
			jumpSound.Play ();
		}
	}

}//End of Monobehavior
