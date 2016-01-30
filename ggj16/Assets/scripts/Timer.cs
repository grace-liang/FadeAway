using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private float startTime = 0.0f;
    private string textTime;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        float timePassed = Time.time - startTime;
        int minutes = (int)timePassed / 60;
        int seconds = (int)timePassed % 60;
        float fraction = (timePassed * 100 ) % 100;

        textTime = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
        this.GetComponent<Text>().text = textTime;
	}
}
