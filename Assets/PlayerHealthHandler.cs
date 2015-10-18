using UnityEngine;
using System.Collections;

public class PlayerHealthHandler : MonoBehaviour {

	public int leftHP = 10; //player 1 health (left hand)
	public int rightHP = 10; //player 2 health (right hand)
	private GameObject leftHealthText;
	private GameObject rightHealthText;
	private bool damagePossible = true;

	private AudioSource pointSoundSource;
	private AudioSource victorySoundSource;
	private AudioSource musicSource;

	private GameObject fightText;


	// Use this for initialization
	void Start () {
		leftHealthText = GameObject.Find ("LeftHealthText");
		rightHealthText = GameObject.Find ("RightHealthText");
		pointSoundSource = transform.FindChild ("pointSoundPlayer").gameObject.GetComponent<AudioSource> ();
		victorySoundSource = transform.FindChild ("victorySoundPlayer").gameObject.GetComponent<AudioSource> ();
		musicSource = GameObject.Find ("MusicPlayer").GetComponent<AudioSource> ();
		fightText = GameObject.Find ("Fight");
	
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public void damage(string hand) {
		if (damagePossible) {
			if (hand.Equals ("Left")) {
				leftHP--;
				leftHealthText.GetComponent<TextMesh> ().text = leftHP.ToString ();
				pointSoundSource.Play();
				if (leftHP < 1) {
					musicSource.Stop();
					victorySoundSource.Play();
					rightHealthText.GetComponent<TextMesh> ().text = "WIN";
					leftHealthText.GetComponent<TextMesh> ().text = "LOSE";
					damagePossible = false;
					StartCoroutine("resetLevelAfterWait");
				}
			} else {
				rightHP--;
				rightHealthText.GetComponent<TextMesh> ().text = rightHP.ToString ();
				pointSoundSource.Play();
				if (rightHP < 1) {
					musicSource.Stop();
					victorySoundSource.Play();
					leftHealthText.GetComponent<TextMesh> ().text = "WIN";
					rightHealthText.GetComponent<TextMesh> ().text = "LOSE";
					damagePossible = false;
					StartCoroutine("resetLevelAfterWait");
				}
			}
		}
	}

	public void damageLeft () {
		damage ("Left");
	}

	public void damageRight () {
		damage ("Right");
	}

	public IEnumerator resetLevelAfterWait() {
		yield return new WaitForSeconds(5);
		resetLevel ();
	}

	public void resetLevel () {
		Debug.Log("resetting");
		leftHP = 10;
		rightHP = 10;
		leftHealthText.GetComponent<TextMesh> ().text = leftHP.ToString ();
		rightHealthText.GetComponent<TextMesh> ().text = rightHP.ToString ();
		musicSource.Play ();
		GameObject.Find ("StartupSeq").SendMessage ("startNewFight");
		damagePossible = true;
	}
}
