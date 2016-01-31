using UnityEngine;
using System.Collections;

public class FireballUD : MonoBehaviour
{

	private int speed = 5;
	private bool moveDown;

	void Start ()
	{
		moveDown = false;
	}

	void Update ()
	{
		if (moveDown) {
			Debug.Log ("Moving down now.");
			gameObject.GetComponent<Animator> ().runtimeAnimatorController = Resources.Load ("fbStartDown") as RuntimeAnimatorController;
			transform.Translate (Vector3.down * speed * Time.deltaTime);
		} else {
			Debug.Log ("Moving up now.");
			gameObject.GetComponent<Animator> ().runtimeAnimatorController = Resources.Load ("fbStartUp") as RuntimeAnimatorController;
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		}
	}

	public void reverseDirection ()
	{
		moveDown = !moveDown;
		Debug.Log (moveDown);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("Trigger");
		if (other.tag == "Wall") {
			reverseDirection ();
		}
	}
}
