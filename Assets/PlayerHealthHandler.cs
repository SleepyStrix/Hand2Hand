using UnityEngine;
using System.Collections;

public class PlayerHealthHandler : MonoBehaviour {

	public int leftHP = 100; //player 1 health (left hand)
	public int rightHP = 100; //player 2 health (right hand)

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void damage(string hand) {
		if (hand.Equals("Left")) {
			leftHP--;
		}
		else {
			rightHP--;
		}
	}
}
