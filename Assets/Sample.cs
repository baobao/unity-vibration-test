using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using info.shibuya24;

public class Sample : MonoBehaviour 
{
    void OnGUI ()
    {
        if (GUILayout.Button ("Vibration 1", GUILayout.Width (300f), GUILayout.Height (200f)))
        {
            VibrationPlugin.PlayVibration (1);
        }
        if (GUILayout.Button ("Vibration 2", GUILayout.Width (300f), GUILayout.Height (200f)))
        {
            VibrationPlugin.PlayVibration (2);
        }
        if (GUILayout.Button ("Vibration 5", GUILayout.Width (300f), GUILayout.Height (200f)))
        {
            VibrationPlugin.PlayVibration (5);
        }
        if (GUILayout.Button ("Vibration Unity", GUILayout.Width (300f), GUILayout.Height (200f)))
        {
            Handheld.Vibrate ();
        }
    }
}
