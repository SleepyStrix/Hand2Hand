using UnityEngine;
using System.Collections;

public class TutorialSequence : MonoBehaviour {

	public GameObject[] seq;

	// Use this for initialization
	void Start () {
		StartCoroutine ("tutSeq");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public IEnumerator tutSeq() {
		seq [0].active = true;
		yield return new WaitForSeconds(4);
		seq [1].active = true;
		yield return new WaitForSeconds(4);
		seq [2].active = true;
		yield return new WaitForSeconds(4);
		seq [3].active = true;
		yield return new WaitForSeconds(4);
		seq [4].active = true;
		yield return new WaitForSeconds(4);
		seq [0].active = false;
		seq [1].active = false;
		seq [2].active = false;
		seq [3].active = false;
		seq [4].active = false;
		seq [5].active = true;
		seq [6].active = true;
		yield return new WaitForSeconds(2);
		Destroy (gameObject);
	}
}
