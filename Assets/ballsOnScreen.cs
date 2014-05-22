using UnityEngine;
using System.Collections;

public class ballsOnScreen : MonoBehaviour
{
	
		// Attach this to a GUIText to make a frames/second indicator.
		//
		// It calculates frames/second over each updateInterval,
		// so the display does not keep changing wildly.
		//
		// It is also fairly accurate at very low FPS counts (<10).
		// We do this not by simply counting frames per interval, but
		// by accumulating FPS for each frame. This way we end up with
		// correct overall FPS even if the interval renders something like
		// 5.5 frames.
	
		public  float updateInterval = 0.5F;
	
		private float accum = 0; // FPS accumulated over the interval
		private int   frames = 0; // Frames drawn over the interval
		private float timeleft; // Left time for current interval
		public static string count = "empty"; // Left time for current interval
	
		void Start ()
		{
				if (!guiText) {
						Debug.Log ("UtilityFramesPerSecond needs a GUIText component!");
						enabled = false;
						return;
				}
				timeleft = updateInterval;  
		}
	
		void Update ()
		{

				// display two fractional digits (f2 format)
				float fps = accum / frames;

				GameObject[] getCount;
				getCount = GameObject.FindGameObjectsWithTag ("ball");
				count = getCount.Length.ToString ();
			
				//string numBallText = 
				//Debug.Log (count);
				string format = System.String.Format ("Num Balls: " + count);
				guiText.text = format;
				guiText.fontSize = 30;


		}
}