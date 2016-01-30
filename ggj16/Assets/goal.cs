using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour {

	private player_movement player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType (typeof(player_movement)) as player_movement;
	}
	
	void OnTriggerEnter2D (Collider2D other) {
	//	death ();
		player.add_power(25);
		Debug.Log ("Power level: "+player.get_power ());
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
		
}
