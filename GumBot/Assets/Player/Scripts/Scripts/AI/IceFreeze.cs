using UnityEngine;
using System.Collections;

public class IceFreeze : MonoBehaviour {
    public CharacterMotor2 Motor;
    public float frozenTime = 1;
    
    // Use this for initialization
    void Start () {
        Motor = GetComponent<CharacterMotor2>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider Collider)
    {
        if (Collider.gameObject.tag == "IceShot")
        {
            StartCoroutine(freeze());
           
        }
    }
    IEnumerator freeze() {
        Motor.speed = 0;
        yield return new WaitForSeconds(frozenTime);
<<<<<<< HEAD
        if (Motor.facingRight == true) {
            Motor.speed = 5;
        }
        else
        if (Motor.facingRight == false) {
            Motor.speed = -5;
        }
=======
        Motor.speed = 5;
>>>>>>> 1a4bd6b1d9e9cc9836dcb24f130c5a4f46ab88d8
    }
}
