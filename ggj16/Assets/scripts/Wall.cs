using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	private bool wallsHidden;

    // Use this for initialization
    void Start () {
		wallsHidden = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!wallsHidden && Time.fixedTime > 2) {
			this.GetComponent<SpriteRenderer>().color = Color.white;
		}

        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

	void OnTriggerEnter2D (Collider2D other) {
		Debug.Log ("COLLISION");
	}
		

}
