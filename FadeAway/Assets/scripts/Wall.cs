using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{
	private Player player;
	private double powerUsageRate = 3;
    
	protected float fadeDuration = 2;
	private float timer = 0;

	void Start ()
	{
		player = FindObjectOfType (typeof(Player)) as Player;
	}

	protected void Update ()
	{

        // Fade the walls from red to white gradually over fadeDuration.
        Color change = this.GetComponent<SpriteRenderer>().material.color;// = Color.Lerp (Color.red, Color.white, timer);
        change.a = 1 - timer;
        this.GetComponent<SpriteRenderer>().material.color = change;
        if (timer < 1) {
			timer += Time.deltaTime / fadeDuration;
		}

		// Light up the walls and reduce the player's power.
		if (Input.GetKey (KeyCode.Space) && player.GetPower () > 0) {
			this.GetComponent<SpriteRenderer> ().color = Color.red;
			player.MinusPower (powerUsageRate);
			Debug.Log ("Player's power level: " + player.GetPower ());
		}
	}
		
	public void AddDuration ()
	{
		timer -= 0.3f;
	}
}
