//using System.Collections;
//using UnityEngine;

//public class TimeScaleGame
//{
//    static float time = 1f;
//    public static IEnumerator TimeScale()
//    {
//        Time.timeScale = 0.1f;
//        yield return new WaitForSeconds(time);
//        Time.timeScale = 1.0f;
//        yield return null;
//    }
//}

using System.Collections;
using UnityEngine;

public class TimeScaleGame : MonoBehaviour
{
    static float time = 3.0f;
    static float slowTimeScale = 0.1f;
    static float originalFixedDeltaTime = Time.fixedDeltaTime;

    static bool isRunning;


    public static IEnumerator TimeScale()
    {
        if(isRunning) { yield break; }
        isRunning = true;
        print("before: " + Time.fixedDeltaTime + ", " + Time.timeScale);

        Time.timeScale = slowTimeScale;
        Time.fixedDeltaTime = originalFixedDeltaTime * slowTimeScale; // Adjust the fixed time step
        print("when: " + Time.fixedDeltaTime + ", " + Time.timeScale);

        yield return new WaitForSeconds(time * slowTimeScale);
        Time.timeScale = 1.0f;
        print("on courutine, originalFixedDeltaTime: " + originalFixedDeltaTime);

        Time.fixedDeltaTime = originalFixedDeltaTime; // Restore the original fixed time step
        print("after: " + Time.fixedDeltaTime + ", " + Time.timeScale);
        isRunning = false;
        yield return null;
    }
}