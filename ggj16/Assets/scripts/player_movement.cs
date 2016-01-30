using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	private int speed = 5;
	public int powerlevel = 100;
	// Use this for initialization
	void Start () {
	
	}

	public int get_power()
	{
		return powerlevel;
	}

	void set_power(int number)
	{
		powerlevel = number;
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
}
