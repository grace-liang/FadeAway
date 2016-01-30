using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour {

	private bool wallsHidden;
	private float time_since_start;
	private player_movement player;
	private double power_usage = 3;

	// For colour fade.
	private float fadeDuration = 6;
	private float timer = 0;

    // Use this for initialization
    void Start () {
		player = FindObjectOfType (typeof(player_movement)) as player_movement;
		time_since_start = 0;
		wallsHidden = false;
	}
	
	// Update is called once per frame
	void Update () {

		// Fade the walls from red to white over fadeDuration.
		this.GetComponent<SpriteRenderer> ().color = Color.Lerp (Color.red, Color.white, timer);
		if (timer < 1) {
			timer += Time.deltaTime / fadeDuration;
		}

		if (Input.GetKey(KeyCode.Space) && player.get_power() > 0)
		{
			this.GetComponent<SpriteRenderer>().color = Color.red;
			player.minus_power (power_usage);
			Debug.Log ("Power level: "+player.get_power ());
		}
    }

	void OnTriggerEnter2D (Collider2D other) {
		death ();
	}

	void death() {
		//TODO - change to Get scene 0.
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
		

}
