using UnityEngine;
using System.Collections;

public class button_gate_south : MonoBehaviour {
	float timeLeft = 0.5f;
	bool countDownStart = false;
	private GameObject gate;

	void OnTriggerEnter2D (Collider2D other)
	{
		countDownStart = true;
	}
	void OnTriggerExit2D (Collider2D other)
	{
		countDownStart = false;
	}

	void Update()
	{
		if (timeLeft <= 0) {
			Debug.Log ("Time has hit 0");
			gate = GameObject.Find ("Gate_South");
			Destroy (gate.GetComponent<Collider2D> ());
			Destroy (gate.GetComponent<SpriteRenderer> ());
			Destroy (this.gameObject);
		}
		if (countDownStart && timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			Debug.Log (timeLeft);
		} else {
			timeLeft = 0.5f;
		}
	}
}
