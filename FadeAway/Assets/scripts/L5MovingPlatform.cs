using UnityEngine;
using System.Collections;

public class L5MovingPlatform : MonoBehaviour {

	public bool moveLeft;
	private float timer = 0;
	private float fadeDuration = 5;

	// Use this for initialization
	void Start () {
		moveLeft = Random.value < 0.5;
	}
	
	// Update is called once per frame
	void Update () {

		if (moveLeft) {
			transform.Translate (Vector3.left * 5 * Time.deltaTime);
		} else {
			transform.Translate (Vector3.right * 5 * Time.deltaTime);
		}

		// Fade the platforms from red to white gradually over fadeDuration.
		Color change = this.GetComponent<SpriteRenderer>().material.color;
		change.a = 1 - timer;
		this.GetComponent<SpriteRenderer>().material.color = change;
		if (timer < 1) {
			timer += Time.deltaTime / fadeDuration;
		}

		// Light up the walls and reduce the player's power.
		double powerUsageRate = 3;

		if (Input.GetKey (KeyCode.Space) && Global.GetPower () > 0) {
			GetComponent<SpriteRenderer> ().color = Color.red;
			Global.MinusPower (powerUsageRate);
			Debug.Log ("Player's power level: " + Global.GetPower ());
		}
	}

	public void reverseDirection() {
		moveLeft = !moveLeft;
	}

}