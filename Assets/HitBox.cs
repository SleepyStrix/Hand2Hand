using UnityEngine;
using System.Collections;

public class HitBox : MonoBehaviour {
	public string hand;
	public GameObject handObj;

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
		if (hand.Equals ("Left")) {
			handObj = GameObject.Find("LeftPalmSpot");
		}
		else if (hand.Equals ("Right")) {
			handObj = GameObject.Find("RightPalmSpot");
		}
		if (handObj != null) {
			transform.position = handObj.transform.position;
		} else {
			transform.position = new Vector3(0, 500, 0);
		}
	}

	/*void OnTriggerStay (Collider other) {
		GameObject collided = other.gameObject;
		Debug.Log(collided);
	}*/
}
