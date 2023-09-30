using System.Collections;
using UnityEngine;

public class TimeScaleGame
{
    static float time = 5.0f;
    public static IEnumerator TimeScale()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(time);
        Time.timeScale = 1.0f;
        yield return null;
    }
}
