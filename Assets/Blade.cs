using UnityEngine;
using System.Collections;

public class Blade : MonoBehaviour {
	public string hand;
	public GameObject healthHandler;


	// Use this for initialization
	void Start () {
		healthHandler = GameObject.Find ("PlayerHealthHandler");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

	void OnTriggerEnter(Collider other) {
		GameObject collided = other.gameObject;
		//if (collided.name.Equals ("HitBox")) {
			Debug.Log(collided);
			if (hand.Equals("Left")) {
				healthHandler.SendMessage("damageRight");
			}
			if (hand.Equals("Right")) {
				healthHandler.SendMessage("damageLeft");
			}
		//}
	}
}
