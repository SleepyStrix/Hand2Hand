using UnityEngine;
using System.Collections;

public class Blade : MonoBehaviour {
	public string hand;
	private GameObject healthHandler;
	private bool canDamage = true;
	//private GameObject leftBlade;
	//private GameObject rightBlade;


	// Use this for initialization
	void Start () {
		healthHandler = GameObject.Find ("PlayerHealthHandler");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

	void OnTriggerEnter(Collider other) {
		GameObject collided = other.gameObject;
		if (canDamage) {
			if (hand.Equals ("Left")) {
				if (collided.name.Equals ("HitBoxRight")) {
					GameObject.Find("RightBlade").SendMessage("bladeCross");
					SendMessage("bladeCross");
					healthHandler.SendMessage ("damageRight");
					GameObject.Destroy(GameObject.Find("RightBladeSpot"));
					GameObject.Destroy(GameObject.Find("LeftBladeSpot"));
				}
				if (collided.name.Equals ("BladeHitBoxRight")) {
					GameObject.Find("RightBlade").SendMessage("bladeCross");
					SendMessage("bladeCross");
					GameObject.Destroy(GameObject.Find("RightBladeSpot"));
					GameObject.Destroy(GameObject.Find("LeftBladeSpot"));
					//GameObject.Find("HitBoxLeft").GetComponent<CapsuleCollider>().enabled = false;
					//collided.GetComponent<CapsuleCollider>().enabled = false;
				}
			}
			if (hand.Equals ("Right")) {
				if (collided.name.Equals ("HitBoxLeft")) {
					GameObject.Find("LeftBlade").SendMessage("bladeCross");
					SendMessage("bladeCross");
					healthHandler.SendMessage ("damageLeft");
					GameObject.Destroy(GameObject.Find("RightBladeSpot"));
					GameObject.Destroy(GameObject.Find("LeftBladeSpot"));;
				}
				if (collided.name.Equals ("BladeHitBoxLeft")) {
					GameObject.Find("LeftBlade").SendMessage("bladeCross");
					SendMessage("bladeCross");
					GameObject.Destroy(GameObject.Find("RightBladeSpot"));
					GameObject.Destroy(GameObject.Find("LeftBladeSpot"));
					//GameObject.Find("HitBoxRight").GetComponent<CapsuleCollider>().enabled = false;
					//collided.GetComponent<CapsuleCollider>().enabled = false;
				}
			}
		}
	}

	void bladeCross() {
		canDamage = false;
		Debug.Log ("bladeCross");
		GetComponent<MeshRenderer> ().enabled = false;

		//StartCoroutine ("bladeRetract");
	}

	/*public IEnumerator bladeRetract() {
		Debug.Log ("corout active");
		GetComponent<MeshRenderer> ().enabled = false;
		yield return new WaitForSeconds (2);
		GetComponent<MeshRenderer> ().enabled = true;
	}*/
}
