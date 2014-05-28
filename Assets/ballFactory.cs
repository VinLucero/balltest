using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ballFactory : MonoBehaviour
{
	
		public Vector2 mouseyPosition;
		public GameObject purpleProjectile;
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
	
	
		public List<GameObject> balls = new List<GameObject> ();
	
		void LaunchPurpleProjectile ()
		{
				GameObject projectileClone = (GameObject)Instantiate (purpleProjectile, cannonStart, transform.rotation);
				projectileClone.GetComponent<ballInformation> ().charged = true;
				Debug.Log ("mouseyPosition: " + mouseyPosition);
				Debug.Log ("mouseyPositionNormal: " + mouseyPosition.normalized);
				projectileClone.rigidbody2D.AddForce (calculatedVector.normalized * firepower);
				Debug.Log ("CORRECT? " + calculatedVector);
		}
	
		// Use this for initialization
		void Start ()
		{
				balls.Add (purpleProjectile);
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				calculatedVector = mouseyPosition - cannonStart;
				string newCountReference = ballsOnScreen.count;
				mouseyPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		
		
				Vector2 fingerPosition = Vector2.zero;
		
				if (Input.touchCount == 1 || Input.GetButtonDown ("Fire1")) {
			
						CancelInvoke ();
						InvokeRepeating ("LaunchPurpleProjectile", 0.1f, rateOfFire);
			
				}
		
		
				if (fingerPosition != Vector2.zero) {
						GameObject targetObj = GameObject.FindGameObjectWithTag ("target");
						targetObj.transform.position = fingerPosition;
				} else {
						GameObject targetObj = GameObject.FindGameObjectWithTag ("target");
						targetObj.transform.position = mouseyPosition;
				}
		
		
				//print (balls [0].GetComponent<ballInformation> ().colorofball.ToString ());
		}
}



/*
public class GunsFactory : MonoBehavior
{
		public List<GameObject> guns = new List<GameObject> ();
	
		public GameObject CreateGun (int gunIndex)
		{
				return Instantiate (guns [gunIndex]);
		}
}

*/