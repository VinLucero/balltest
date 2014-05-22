
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class cannonFire : MonoBehaviour
{
		public Vector2 mouseyPosition;
		public Rigidbody2D purpleProjectile;
		private Rigidbody2D purpleProjectileClone;
		public Rigidbody2D orangeProjectile;
		private Rigidbody2D orangeProjectileClone;
		public Rigidbody2D greenProjectile;
		private Rigidbody2D greenProjectileClone;
		public Rigidbody2D redProjectile;
		private Rigidbody2D redProjectileClone;
		private Vector2 cannonStart = new Vector2 (0f, 3.55f);
		private Vector2 calculatedVector;
		public int firepower = 500;
		public float rateOfFire = 0.1f;
		
	
		void LaunchPurpleProjectile ()
		{
				Rigidbody2D purpleProjectileClone = (Rigidbody2D)Instantiate (purpleProjectile, cannonStart, transform.rotation);
				purpleProjectileClone.GetComponent<ballInformation> ().charged = true;
				Debug.Log ("mouseyPosition: " + mouseyPosition);
				Debug.Log ("mouseyPositionNormal: " + mouseyPosition.normalized);
				purpleProjectileClone.rigidbody2D.AddForce (calculatedVector.normalized * firepower);
				Debug.Log ("CORRECT? " + calculatedVector);
		}

		void LaunchOrangeProjectile ()
		{
				Rigidbody2D orangeProjectileClone = (Rigidbody2D)Instantiate (orangeProjectile, cannonStart, transform.rotation);
				orangeProjectileClone.GetComponent<ballInformation> ().charged = true;
				orangeProjectileClone.rigidbody2D.AddForce (calculatedVector.normalized * firepower);
		}
		
		void LaunchGreenProjectile ()
		{
				Rigidbody2D greenProjectileClone = (Rigidbody2D)Instantiate (greenProjectile, cannonStart, transform.rotation);
				greenProjectileClone.GetComponent<ballInformation> ().charged = true;
				greenProjectileClone.rigidbody2D.AddForce (calculatedVector.normalized * firepower);
		}
		
		
		void LaunchRedProjectile ()
		{
				Rigidbody2D redProjectileClone = (Rigidbody2D)Instantiate (redProjectile, cannonStart, transform.rotation);
				redProjectileClone.GetComponent<ballInformation> ().charged = true;
				redProjectileClone.rigidbody2D.AddForce (calculatedVector.normalized * firepower);
		}
		
		
		void LaunchRandomProjectile ()
		{
				int rand = Random.Range (0, 4);
				
				if (rand == 0) {
						LaunchOrangeProjectile ();
				} else if (rand == 1) {
						LaunchGreenProjectile ();
				} else if (rand == 2) {
						LaunchPurpleProjectile ();
				} else if (rand == 3) {
						LaunchRedProjectile ();
				}
		
				print ("rand: " + rand);
		}
	
		void Start ()
		{

		}
	
		void Update ()
		{
				calculatedVector = mouseyPosition - cannonStart;
				string newCountReference = ballsOnScreen.count;
				mouseyPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);


				Vector2 fingerPosition = Vector2.zero;

				if (Input.touchCount == 1 || Input.GetButtonDown ("Fire1")) {

						CancelInvoke ();
						InvokeRepeating ("LaunchRandomProjectile", 0.1f, rateOfFire);
						
				}

				
				if (Input.touchCount == 2 || Input.GetKeyDown (KeyCode.RightShift)) {
						CancelInvoke ();
						InvokeRepeating ("LaunchOrangeProjectile", 0.1f, 0.5f);
				}


				if (fingerPosition != Vector2.zero) {
						gameObject.transform.position = fingerPosition;
				} else {
						gameObject.transform.position = mouseyPosition;
				}
		}
}