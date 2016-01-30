using UnityEngine;
using System.Collections;

public class Level4Player : MonoBehaviour {

	private readonly int speed = 5;
	bool platformEntered;

	// Use this for initialization
	void Start () {
		platformEntered = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(Vector3.up * speed *Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(Vector3.down * speed *Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(Vector3.left * speed *Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(Vector3.right * speed *Time.deltaTime);
		}

	
	}



	void circleMovement(bool moveleft) {
		Debug.Log ("CIRCLE MOVEMENT");
		if (moveleft) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		} else {
			transform.Translate(Vector3.right * speed *Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		
		//platformEntered = true;
		float step = speed * Time.deltaTime;
		// Move our position a step closer to the target.
		float x_value = other.GetComponent<Transform>().position.x;
		float y_value = this.GetComponent<Transform>().position.y;
		float z_value = this.GetComponent<Transform>().position.z;
		Vector3 new_positions = new Vector3 (x_value, y_value, z_value);
		transform.position = Vector3.MoveTowards(transform.position, new_positions, step);
	

	}

	void OnTriggerStay2D(Collider2D other) {
		
		//platformEntered = true;
		float step = speed * Time.deltaTime;
		// Move our position a step closer to the target.
		float x_value = other.GetComponent<Transform>().position.x;
		float y_value = this.GetComponent<Transform>().position.y;
		float z_value = this.GetComponent<Transform>().position.z;
		Vector3 new_positions = new Vector3 (x_value, y_value, z_value);
		transform.position = Vector3.MoveTowards(transform.position, new_positions, step);


	}


	void OnTriggerExit2D(Collider2D other) {
		
	}
}
