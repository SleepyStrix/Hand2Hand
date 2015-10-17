using UnityEngine;
using System.Collections;

public class HitBox : MonoBehaviour {
	public string hand;
	private GameObject targObj;
	public bool forBlade = false;


	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
		if (!forBlade) {
			if (hand.Equals ("Left")) {
				targObj = GameObject.Find ("LeftPalmSpot");
			} else if (hand.Equals ("Right")) {
				targObj = GameObject.Find ("RightPalmSpot");
			}
			if (targObj != null) {
				transform.position = targObj.transform.position;
				transform.rotation = targObj.transform.rotation;
			} 
			else {
				transform.position = new Vector3 (0, 500, 0);
			}
		} else {
			if (hand.Equals ("Left")) {
				targObj = GameObject.Find ("LeftBladeSpot");
			} else if (hand.Equals ("Right")) {
				targObj = GameObject.Find ("RightBladeSpot");
			}
			if (targObj != null) {
				transform.position = targObj.transform.position;
				transform.rotation = targObj.transform.rotation;
			} 
			else {
				if (hand.Equals("Left")) {
					transform.position = new Vector3 (100, 800, 0);
				}
				else {
					transform.position = new Vector3 (300, 800, 0);
				}

			}
		}

	}

	/*void OnTriggerStay (Collider other) {
		GameObject collided = other.gameObject;
		Debug.Log(collided);
	}*/
}
