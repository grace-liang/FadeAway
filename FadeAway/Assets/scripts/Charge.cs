using UnityEngine;
using System.Collections;

public class Charge : MonoBehaviour
{
	private Wall[] walls;


	void Start ()
	{
		walls = FindObjectsOfType (typeof(Wall)) as Wall[];
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("Player collided with a charge.");

		foreach (Wall w in walls) {
			w.AddDuration ();
		}

		Destroy (gameObject);
	}
}
