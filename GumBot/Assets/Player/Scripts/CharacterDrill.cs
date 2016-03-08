using UnityEngine;
using System.Collections;

public class CharacterDrill : MonoBehaviour {


    public GameObject bullet;
    public GameObject PlasmaBullet;
    public Transform shootingPoint;
    public float damage = 1;
    public float Plasmadamage = 2;
    public float reloadTime = 0.5f;
    public float RapidReload = 0.25f;
    public bool reloading;
    public DrillUpgrades DrillUPG;

    // This should either be EnemyBullet or PlayerBullet. Set it to that in the editor
    public string bulletTag;


    void Start()
    {
        DrillUPG = GetComponent<DrillUpgrades>();
    }

    public void shot()
    {
        if (!reloading && DrillUPG.PlamsaDrill == false && DrillUPG.RapidDrill == false && DrillUPG.PowerDrill == false)
        {
            bullet.GetComponent<bulletMovement>().theCharacterMotor = gameObject.GetComponent<CharacterMotor2>();
            bullet.GetComponent<bulletMovement>().damage = damage;
            bullet.gameObject.tag = bulletTag;
            Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
            StartCoroutine("ShotCo");
        }

        if (!reloading && DrillUPG.PlamsaDrill == true)
        {
            bullet.GetComponent<bulletMovement>().theCharacterMotor = gameObject.GetComponent<CharacterMotor2>();
            bullet.GetComponent<bulletMovement>().damage = Plasmadamage;
            bullet.gameObject.tag = bulletTag;
            Instantiate(PlasmaBullet, shootingPoint.position, shootingPoint.rotation);
            StartCoroutine("ShotCo");
        }

        if (!reloading && DrillUPG.RapidDrill == true)
        {
            bullet.GetComponent<bulletMovement>().theCharacterMotor = gameObject.GetComponent<CharacterMotor2>();
            bullet.GetComponent<bulletMovement>().damage = damage;
            bullet.gameObject.tag = bulletTag;
            Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
            StartCoroutine("RapidShotCo");
        }

        if (!reloading && DrillUPG.PowerDrill == true)
        {
            bullet.GetComponent<bulletMovement>().theCharacterMotor = gameObject.GetComponent<CharacterMotor2>();
            bullet.GetComponent<bulletMovement>().damage = Plasmadamage;
            bullet.gameObject.tag = bulletTag;
            Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
            StartCoroutine("ShotCo");
        }
    }

    IEnumerator ShotCo()
    {
        reloading = true;

        yield return new WaitForSeconds(reloadTime);

        reloading = false;

    }

    IEnumerator RapidShotCo()
    {
        reloading = true;

        yield return new WaitForSeconds(RapidReload);

        reloading = false;

    }
}

