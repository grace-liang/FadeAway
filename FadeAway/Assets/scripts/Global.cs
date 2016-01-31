using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Global
{

	// The position of the current level in the build index.
	// + 1 if including Start Menu.
	public static int level = SceneManager.GetActiveScene ().buildIndex + 1;

	// Available alloted for each level.
	public static float[] times = new float[5] { 15.0f, 20.0f, 20.0f, 25.0f, 30.0f };
}
