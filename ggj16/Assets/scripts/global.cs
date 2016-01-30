using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Global
{
    public static int level = SceneManager.GetActiveScene().buildIndex + 1;
    public static float[] times = new float[5] { 15.0f, 20.0f, 20.0f, 25.0f, 30.0f };
}
