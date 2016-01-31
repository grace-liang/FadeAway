using UnityEngine;
using System.Collections;

public class L5MovingPlatform : MonoBehaviour {

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
	}

}