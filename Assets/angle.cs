using UnityEngine;
using System.Collections;

public class angle : MonoBehaviour {
	
	public GameObject InputOne;
	public GameObject InputTwo;

	
	// Use this for initialization
	void Start () {
		/*
		Debug.Log("InputOne: " + InputOne);
		Debug.Log("InputOne X: " + InputOne.transform.position.x);
		Debug.Log("InputOne Y: " + InputOne.transform.position.y);

		Debug.Log("InputTwo: " + InputTwo);
		Debug.Log("InputTwo X: " + InputTwo.transform.position.x);
		Debug.Log("InputTwo Y: " + InputTwo.transform.position.y);
		*/
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(Vector3.Angle(Vector3.right, InputOne.transform.position - InputTwo.transform.position));
	}
	
}
