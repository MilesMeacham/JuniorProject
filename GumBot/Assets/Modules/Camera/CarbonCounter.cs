using UnityEngine;
using System.Collections;

public class CarbonCounter : MonoBehaviour {

    public static int carbontotal = 0;
    public static int irontotal = 0;
    public static int silicatotal = 0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        {
            string carbontext = "Carbon Count: " + carbontotal;
            GUI.Box(new Rect(Screen.width - 150, 20, 130, 20), carbontext);
        }
        {
            string irontext = "Iron Count: " + irontotal;
            GUI.Box(new Rect(Screen.width - 150, 45, 130, 20), irontext);
        }
        {
            string silicatext = "Silica Count: " + silicatotal;
            GUI.Box(new Rect(Screen.width - 150, 70, 130, 20), silicatext);
        }
    }
}
