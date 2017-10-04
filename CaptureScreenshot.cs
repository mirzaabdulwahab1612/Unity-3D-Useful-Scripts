using UnityEngine;
using System.Collections;

public class CaptureScreenshot : MonoBehaviour {

	static int number = 1;

    [Range(0, 5)]
    public float timeScaler = 1f;
    [Space(2)]
    public bool enableCanvas = true;
    [Space(5)]
    public GameObject mainCanvas;

    void Update ()
	{
        Time.timeScale = timeScaler;

		if(Input.GetKeyDown(KeyCode.P))
		{
			Application.CaptureScreenshot ("F:\\"+number.ToString() + ".png",3); 
			number += 1;
		}

        if (enableCanvas) {
            mainCanvas.SetActive (true);
        }
        else
        {
            mainCanvas.SetActive (false);
        }
    }
}
