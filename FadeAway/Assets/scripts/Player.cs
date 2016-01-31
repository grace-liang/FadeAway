using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	private int speed = 5;
	public double power = 100;

	void Update ()
	{
		bool up = Input.GetKey (KeyCode.UpArrow);
		bool down = Input.GetKey (KeyCode.DownArrow);
		bool left = Input.GetKey (KeyCode.LeftArrow);
		bool right = Input.GetKey (KeyCode.RightArrow);

		if (up) {
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		}
		if (down) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
		}
		if (left) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}
		if (right) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}
	}

	public double GetPower ()
	{
		return power;
	}

	public void AddPower (double number)
	{
		double newPower;
		newPower = power += number;
		if (newPower > 100) {
			power = 100;
		} else {
			power = newPower;
		}
	}

	public void MinusPower (double number)
	{
		double newPower;
		newPower = power -= number;
		if (newPower < 0) {
			power = 0;
		} else {
			power = newPower;
		}
	}
}
