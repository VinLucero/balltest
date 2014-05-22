using UnityEngine;
using System.Collections;

public class ballInformation : MonoBehaviour
{


		public string colorofball = "EMPTY COLOR";
		public bool charged = false;

		void OnCollisionStay2D (Collision2D coll)
		{
				if (coll.gameObject.tag == "ball") {
						
						//Debug.Log ("COLLISION");
						if (this.gameObject.GetComponent<ballInformation> ().colorofball
								== coll.gameObject.GetComponent<ballInformation> ().colorofball) {

								if (this.gameObject.GetComponent<ballInformation> ().charged == true || 
										this.gameObject.GetComponent<ballInformation> ().charged == true) {
										coll.gameObject.GetComponent<ballInformation> ().charged = true;
										this.gameObject.GetComponent<ballInformation> ().charged = true;
										coll.gameObject.GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 0.5f);
										this.gameObject.GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 0.5f);
										Destroy (coll.gameObject, 2.0f);
										Destroy (this.gameObject, 2.0f);
								}
						}
						//Debug.Log ("FINISH");
				}
		}



		// Use this for initialization
		void Start ()
		{
				if (gameObject.name.Contains ("orangeBall")) {
						colorofball = "orange";
				}
		
				if (gameObject.name.Contains ("purpleBall")) {
						colorofball = "purple";
				}
				
				if (gameObject.name.Contains ("greenBall")) {
						colorofball = "green";
				}
				
				if (gameObject.name.Contains ("redBall")) {
						colorofball = "red";
				}
				//Debug.Log (this.gameObject.GetComponent<ballInformation> ().charged);
				

		}
	
		// Update is called once per frame
		void Update ()
		{
				if (gameObject.name.Contains ("orangeBall")) {
						colorofball = "orange";
				}
		
				if (gameObject.name.Contains ("purpleBall")) {
						colorofball = "purple";
				}
		
				if (gameObject.name.Contains ("greenBall")) {
						colorofball = "green";
				}
		
				if (gameObject.name.Contains ("redBall")) {
						colorofball = "red";

				}
		}
}