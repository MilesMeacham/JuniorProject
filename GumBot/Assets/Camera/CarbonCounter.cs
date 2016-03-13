using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CarbonCounter : MonoBehaviour {

    public static int carbontotal = 0;
	public Image carbonBar;
    // Use this for initialization
    void Start () 
	{
      
		carbontotal = 0;
		carbonBar.fillAmount = carbontotal;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (carbontotal >= 6)
        {
            Application.LoadLevel("SuccessScreen");
        }
		carbonBar.fillAmount = carbontotal;
    }

}
