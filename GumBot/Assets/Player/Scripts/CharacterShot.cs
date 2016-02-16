﻿// Author: Jeremy Graham
// Description: Shoots a bullet

using UnityEngine;
using System.Collections;

// CharacterShot
// Script will instatiate a bullet at the shootingPoint

public class CharacterShot : MonoBehaviour {

	public ObjectPooler bulletPools;
    public GameObject bullet;
    public Transform shootingPoint;
	public float damage = 1;
	public float reloadTime = 0.5f;
	public bool reloading;

	// This should either be EnemyBullet or PlayerBullet. Set it to that in the editor
	public string bulletTag;

	private ObjectPooler bulletPooler;

	void Start()
	{
		bulletPools = GameObject.Find ("BulletPooler").GetComponent<ObjectPooler> ();
	}

    public void shot()
    {
		if (!reloading) 
		{
			bullet = bulletPools.GetPooledObject ();
			bullet.GetComponent<bulletMovement> ().theCharacterMotor = gameObject.GetComponent<CharacterMotor2> ();
			bullet.GetComponent<bulletMovement> ().damage = damage;
			bullet.gameObject.tag = bulletTag;
			bullet.transform.position = shootingPoint.transform.position;
			bullet.SetActive (true);
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
