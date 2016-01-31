using UnityEngine;
using System.Collections;

public class FireballLR : MonoBehaviour
{
	
	private int speed = 5;
	private bool moveLeft;

	void Start ()
	{
		moveLeft = false;
	}

	void Update ()
	{
		if (moveLeft) {
			Debug.Log ("Moving left now.");
			gameObject.GetComponent<Animator> ().runtimeAnimatorController = Resources.Load ("fbStartLeft") as RuntimeAnimatorController;
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		} else {
			Debug.Log ("Moving right now.");
			gameObject.GetComponent<Animator> ().runtimeAnimatorController = Resources.Load ("fbStartRight") as RuntimeAnimatorController;
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}
	}

	public void reverseDirection ()
	{
		moveLeft = !moveLeft;
		Debug.Log (moveLeft);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("Trigger");
		if (other.tag == "Wall") {
			reverseDirection ();
		}
	}
}
