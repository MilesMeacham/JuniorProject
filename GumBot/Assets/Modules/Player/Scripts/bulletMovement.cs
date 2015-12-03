using UnityEngine;
using System.Collections;

public class bulletMovement : MonoBehaviour {
    public float shotVelocity;
    public Rigidbody rb;
    public CharacterMotor2 cm;
    public GameObject TheDude;
    public float lifeDuration;
    private Attractor Core;
    public float Xpos;
    public float Ypos;
    public float radius;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        cm = FindObjectOfType<CharacterMotor2>();
        if (cm.facingRight == true)
        {
            rb.velocity = transform.TransformDirection (new Vector3(shotVelocity, 0, 0));
        }
        if (cm.facingRight == false)
        {
            rb.velocity = transform.TransformDirection(new Vector3(-shotVelocity, 0, 0));
        }
        Core = FindObjectOfType<Attractor>();
        radius = Vector3.Distance(rb.position, Core.GetComponent<Transform>().position);
    }
	
	// Update is called once per frame
	void Update () {
        // Xpos = Core.GetComponent<Transform>().position.x + Mathf.Sin*
        Vector3 Xpointer =  (Core.transform.position - transform.position).normalized;
        Xpointer.z = 0;
        float temp = Xpointer.x;
        Xpointer.x = -Xpointer.y;
        Xpointer.y = temp;
     

        if (cm.facingRight == true)
        {
            transform.position = transform.position + (Xpointer/5);

        }
        if (cm.facingRight == false)
        {
            transform.position = transform.position + ((Xpointer*-1)/5);
        }



        StartCoroutine("Destroybullet");
    }
    public IEnumerator Destroybullet()
    {
        yield return new WaitForSeconds(lifeDuration);
        Destroy(gameObject);
    }
}
