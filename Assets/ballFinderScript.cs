using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ballFinderScript : MonoBehaviour
{
		//ballInformation localballinfo; 
		// Use this for initialization
		void Start ()
		{
			
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown ("space")) {
						//Debug.Log ("SPACE WAS PRESSED");
						//Debug.Log ("Hello");


						int count_orange_balls_charged = 0;
						int count_purple_balls_charged = 0;
						int count_orange_balls = 0;
						int count_purple_balls = 0;
			
						List<string> ballColorList = new List<string> ();
				
						GameObject[] ballObjectArray = GameObject.FindGameObjectsWithTag ("ball");
						foreach (GameObject ball in ballObjectArray) {
								if (ball.GetComponent<ballInformation> ().colorofball.Equals ("orange")) {
										count_orange_balls++;
										if (ball.GetComponent<ballInformation> ().charged == true) {
												count_orange_balls_charged++;
										} 
										
								} else if (ball.GetComponent<ballInformation> ().colorofball.Equals ("purple")) {
										count_purple_balls++;
										if (ball.GetComponent<ballInformation> ().charged == true) {
												count_purple_balls_charged++;
										} 
								}
						}


						print ("ORANGE COUNT: " + count_orange_balls.ToString ());
						print ("ORANGE CHARGED COUNT: " + count_orange_balls_charged.ToString ());
		
						print ("PURPLE COUNT: " + count_purple_balls.ToString ());
						print ("PURPLE CHARGED COUNT: " + count_purple_balls_charged.ToString ());
						
						
						
	
						
						/*
						
						
			int caseSwitch = 1;
			switch (caseSwitch)
			{
			case 1:
				Console.WriteLine("Case 1");
				break;
			case 2:
				Console.WriteLine("Case 2");
				break;
			default:
				Console.WriteLine("Default case");
				break;
			}
						
*/

				}

				if (Input.GetKeyDown (KeyCode.LeftShift) || Input.touchCount == 3) {
						Debug.Log ("LEFT SHIFT WAS PRESSED");
						GameObject[] go = GameObject.FindGameObjectsWithTag ("ball");
						foreach (GameObject ballUnique in go) {
								Destroy (ballUnique);
						}
				}
		}

}
