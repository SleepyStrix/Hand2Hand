using UnityEngine;
using System.Collections;

public class ExitControls : MonoBehaviour {

	private bool wantToExit = false;
	private GameObject exitText;
	private bool exitStarted = false;

	// Use this for initialization
	void Start () {
		exitText = GameObject.Find ("ExitText");
		exitText.active = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Cancel")) {
			wantToExit = !wantToExit;
		}
		if (wantToExit && !exitStarted) {
			StartCoroutine ("exitSeq");
		} else if(!wantToExit && exitStarted) {
			exitText.active = false;
			exitStarted = false;
			StopCoroutine("exitSeq");
		}
	
	}

	public IEnumerator exitSeq() {
		exitStarted = true;
		exitText.active = true;
		Debug.Log ("Exiting in 10 sec");
		yield return new WaitForSeconds(10);
		Debug.Log ("Exiting now");
		Application.Quit();
	}
}
