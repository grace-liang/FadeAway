using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	private float goalTime;
	private float remainingTime;
	private string timerText;

	void Start ()
	{
		goalTime = Time.time;
		remainingTime = Global.times [Global.level - 1];
	}

	void Update ()
	{
		remainingTime -= (Time.time - goalTime);
		goalTime = Time.time;

		if (remainingTime < 0) {
			DeathByTimer ();
		}

		SetTimerText (remainingTime);
	}

	void DeathByTimer ()
	{
		remainingTime = Global.times [Global.level - 1];
		SetTimerText (remainingTime * 60);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	void SetTimerText (float time)
	{
		int mm = (int)time / 60;
		int ss = (int)time % 60;
		float fraction = (time * 100) % 100;

		timerText = string.Format ("{0:00}:{1:00}:{2:00}", mm, ss, fraction);
		this.GetComponent<Text> ().text = timerText;
	}
}
