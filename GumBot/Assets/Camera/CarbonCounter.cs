using UnityEngine;
using System.Collections;

public class CarbonCounter : MonoBehaviour {

    public static int carbontotal = 0;
    public static int irontotal = 0;
    public static int silicatotal = 0;
    // Use this for initialization
    void Start () {
      
            irontotal = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (irontotal >= 6)
        {
            Application.LoadLevel("SuccessScreen");
        }
    }
    void OnGUI()
    {
     
        {
            string irontext = "Mineral Count: " + irontotal;
            GUI.Box(new Rect(Screen.width - 150, 45, 130, 20), irontext);
        }
        
    }
}
