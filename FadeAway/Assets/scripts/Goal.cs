using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

	// Goal knows the player so we can add to their power level.
	private Player player;

	void Start ()
	{
		player = FindObjectOfType (typeof(Player)) as Player;
	}

	void OnTriggerEnter2D (Collider2D other)
	{

		// Grant the player more power for beating the level.
		player.AddPower (25);
		Debug.Log ("Player's power level: " + player.GetPower ());
	

		// Advance to the next level.
		Global.level++;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
