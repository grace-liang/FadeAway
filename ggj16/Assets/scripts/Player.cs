using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	private int speed = 5;
	public double powerlevel = 100;
	// Use this for initialization
	void Start () {

	}

	public double get_power()
	{
		return powerlevel;
	}

	public void minus_power(double number)
	{
		double newPow;
		newPow = powerlevel -= number;
		if (newPow < 0)
			powerlevel = 0;
		else
			powerlevel = newPow; 
			
	}

	public void add_power(double number)
	{
		double newPow;
		newPow = powerlevel += number;
		if (newPow > 100) {
			powerlevel = 100;
		} else {
			powerlevel = newPow;
		}
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
