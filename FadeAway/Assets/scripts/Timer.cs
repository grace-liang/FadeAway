using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    
    private float goalTime;
    private float remainingTime;
    private string textTime;
    private bool dead;

	// Use this for initialization
	void Start () {
        dead = false;
        goalTime = Time.time;
        remainingTime = Global.times[Global.level - 1];
	}
	
	// Update is called once per frame
	void Update () {
        remainingTime -= (Time.time - goalTime);
        goalTime = Time.time;

        if(remainingTime < 0)
        {
            death();
        }

        SetText(remainingTime);
	}

    void death()
    {
        remainingTime = Global.times[Global.level - 1];
        SetText(remainingTime * 60);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void SetText(float time)
    {
        int minutes = (int)time / 60;
        int seconds = (int)time % 60;
        float fraction = (time * 100) % 100;

        textTime = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
        this.GetComponent<Text>().text = textTime;
    }
}
