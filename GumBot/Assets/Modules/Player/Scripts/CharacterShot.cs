// Author: Jeremy Graham
// Description: Shoots a bullet

using UnityEngine;
using System.Collections;

// CharacterShot
// Script will instatiate a bullet at the shootingPoint

public class CharacterShot : MonoBehaviour {

 
    public GameObject bullet;
    public Transform shootingPoint;
	public float damage = 1;
	public float reloadTime = 0.5f;
	public bool reloading;

	// This should either be EnemyBullet or PlayerBullet. Set it to that in the editor
	public string bulletTag;

    public void shot()
    {
		if (!reloading) 
		{
			bullet.GetComponent<bulletMovement> ().theCharacterMotor = gameObject.GetComponent<CharacterMotor2> ();
			bullet.GetComponent<bulletMovement> ().damage = damage;
			bullet.gameObject.tag = bulletTag;
			Instantiate (bullet, shootingPoint.position, shootingPoint.rotation);
			StartCoroutine ("ShotCo");
		}

    }

	IEnumerator ShotCo()
	{
		reloading = true;

		yield return new WaitForSeconds (reloadTime);

		reloading = false;
		
	}
}
