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
		GetComponent<SpriteRenderer> ().color = Color.Lerp (Color.red, Color.white, timer);
		if (timer < 1) {
			timer += Time.deltaTime / fadeDuration;
		}

		// Light up the walls and reduce the player's power.
		L5Player player = FindObjectOfType (typeof(L5Player)) as L5Player;
		double powerUsageRate = 3;

		if (Input.GetKey (KeyCode.Space) && player.GetPower () > 0) {
			GetComponent<SpriteRenderer> ().color = Color.red;
			player.MinusPower (powerUsageRate);
			Debug.Log ("Player's power level: " + player.GetPower ());
		}
	}

	public void reverseDirection() {
		moveLeft = !moveLeft;
	}

	void OnTriggerEnter2D(Collider2D other) {
	}

}