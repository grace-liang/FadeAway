using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Global
{


	// The position of the current level in the build index.
	// + 1 if including Start Menu.
	public static int level = SceneManager.GetActiveScene ().buildIndex + 1;

	// Available alloted for each level.
	// First one is for the start menu.
	public static float[] times = new float[6] { 0.0f, 5.0f, 10.0f, 15.0f, 20.0f, 20.0f };

	//Total Power of player
	protected static double power = 100;


	public static double GetPower ()
	{
		return power;
	}

	public static void AddPower (double number)
	{
		double newPower;
		newPower = power += number;
		if (newPower > 100) {
			power = 100;
		} else {
			power = newPower;
		}
	}

	public static void MinusPower (double number)
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
