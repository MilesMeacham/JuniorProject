using UnityEngine;
using System.Collections;

public class KeyboardControls : MonoBehaviour {
	
	private CharacterMotor2 theCharacterMotor;
	private CharacterJump2 theCharacterJump;

	// Use this for initialization
	void Start () 
	{
		theCharacterMotor = gameObject.GetComponent<CharacterMotor2> ();
		theCharacterJump = gameObject.GetComponent<CharacterJump2> ();
	}

	void Update ()
	{
        if (Input.GetKeyDown(KeyCode.Space))
            theCharacterJump.Jump();

        if (Input.GetKeyDown(KeyCode.D))
        {
            theCharacterMotor.RightActivation();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            theCharacterMotor.LeftActivation();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            theCharacterMotor.movingRight=false;
        }


        if (Input.GetKeyUp(KeyCode.A))
        {
            theCharacterMotor.movingLeft=false;
        }
    }


	void FixedUpdate () 
	{

	



    }
	
}
