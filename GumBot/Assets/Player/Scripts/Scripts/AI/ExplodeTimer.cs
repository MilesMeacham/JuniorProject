using UnityEngine;
using System.Collections;

public class ExplodeTimer : MonoBehaviour {

    public float timer = 1;
    public float damage = 1;
    public CharacterMotor2 theCharacterMotor;
    public TakeDamage takeDamage;

    void Start() {
        StartCoroutine(Boom());
    }

    IEnumerator Boom()
    {
       yield return new WaitForSeconds(timer);
        Destroy(gameObject);
    }

}
