using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour {

    public Renderer rend;
	private bool wallsHidden;
	private float time_since_start;
	private player_movement player;
	private double power_usage = 3;

    // Use this for initialization
    void Start () {
		player = FindObjectOfType (typeof(player_movement)) as player_movement;
		time_since_start = 0;
		wallsHidden = false;
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		time_since_start += Time.deltaTime;
		if (!wallsHidden && time_since_start > 2) {
			this.GetComponent<SpriteRenderer>().color = Color.white;
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
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
		

}
