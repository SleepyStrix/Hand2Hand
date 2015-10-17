using UnityEngine;
using System.Collections;

public class PlayerHealthHandler : MonoBehaviour {

	public int leftHP = 100; //player 1 health (left hand)
	public int rightHP = 100; //player 2 health (right hand)
	private GameObject leftHealthText;
	private GameObject rightHealthText;


	// Use this for initialization
	void Start () {
		leftHealthText = GameObject.Find ("LeftHealthText");
		rightHealthText = GameObject.Find ("RightHealthText");
	
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public void damage(string hand) {
		if (hand.Equals("Left")) {
			leftHP--;
			leftHealthText.GetComponent<TextMesh>().text = leftHP.ToString();
		}
		else {
			rightHP--;
			rightHealthText.GetComponent<TextMesh>().text = rightHP.ToString();
		}
	}

	public void damageLeft () {
		damage ("Left");
	}

	public void damageRight () {
		damage ("Right");
	}


}
