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

	IEnumerator OnTriggerEnter2D (Collider2D other)
	{
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

		// Grant the player more power for beating the level.
		Global.AddPower (25);
		Debug.Log ("Player's power level: " + Global.GetPower ());
	

		// Advance to the next level.
		Global.level++;
        float fadeTime = GameObject.Find("_GM").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
