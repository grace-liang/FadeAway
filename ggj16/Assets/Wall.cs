using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    public Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

	void OnTriggerEnter2D (Collider2D other) {
		Debug.Log ("COLLISION");
	}
		

}
