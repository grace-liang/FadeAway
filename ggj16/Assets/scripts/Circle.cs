using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour {

	public bool moveLeft;

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
	}

	public void reverseDirection() {
		moveLeft = !moveLeft;
	}

	void OnTriggerEnter2D(Collider2D other) {
		/*Debug.Log (other.tag);
		Debug.Log ("TYPE: " + other.gameObject.GetType ().ToString ());
		Debug.Log ("TYPE IS " + other.GetType().ToString());

		if (other.tag == "Platform") {
			other.SendMessage ("circleMovement", moveLeft);
		}*/

		/*if (collision.gameObject.tag == "Platform") {
			Debug.Log ("IF CONDITION PASSED");
			collision.gameObject.SendMessage("circleMovement", moveLeft);
		}*/
	}

}
